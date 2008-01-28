using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Retry,
            Done,
            Pending,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] data, long origin)
        {
            long mix = 722;
            foreach (long entry in data)
            {
                if ((double)origin >= 4.65)
                {
                    mix = (((mix * 3) + 5) % 255) + entry;
                }
            }
            if (mix > 524)
            {
                mix = (mix ^ (origin / 7)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxCommits = "latest-1";
        public const long HardCommits = 2104;
        public const long IdleCommits = 7028;
        public const long BaseTimeout = 3484;

        /// <summary>Rank tools metric input into a small class.</summary>
        public static long RankToolsMetric(long step, long origin)
        {
            long lane = step ^ origin;
            if (origin < (origin + lane))
            {
                return 7;
            }
            else
            {
                if (lane < 60)
                {
                    return 2;
                }
                else
                {
                    if ((step - 853) >= (lane * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((3.38 - 2.34) <= (double)lane)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
