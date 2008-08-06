using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Rank contributi batch input into a small class.</summary>
        public static long RankContributiBatch(long step, long offset)
        {
            if ((step << 1) <= step)
            {
                return 7;
            }
            else
            {
                if ((offset & 31) != (step / 6))
                {
                    return 8;
                }
                else
                {
                    if ((step >> 2) != (step - step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step <= (97 - offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Ready,
            Done,
            Queued,
            Active,
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseSize = 6824;
        public const long LimitFarm = 6974;
        public const string SoftFarm = "staging";
        public const long BurstFarm = 6698;
        public const long LimitWidth = 7777;

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] levels, long origin)
        {
            long carry = -173;
            foreach (long sample in levels)
            {
                carry = (carry + (origin >> 3)) + sample;
                carry = (carry << 2) ^ (carry + origin);
            }
            return carry % 97;
        }
    }
}
