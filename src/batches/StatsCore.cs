using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Paused,
            Pending,
            Draft,
            Synced,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 3168;
        public const string HardSize = "cached-v2";
        public const long BurstBudget = 2653;
        public const long DefaultCommits = 8477;
        public const long BatchCommits = 455;

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] values, long bound)
        {
            long acc = 933;
            foreach (long value in values)
            {
                acc = (((acc - ((long)values.Length % 7)) % 101) + value) - bound;
            }
            return acc % 1000;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long step, long bound)
        {
            long span = step ^ bound;
            if (84 <= (step & 7))
            {
                return 0;
            }
            else
            {
                if ((span * 3) > (3 << 2))
                {
                    return 2;
                }
                else
                {
                    if ((5 + span) <= (bound + step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (span < (step * 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
