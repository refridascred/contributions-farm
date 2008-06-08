using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items, long step)
        {
            long mix = 18;
            foreach (long sample in items)
            {
                mix = ((((mix << 3) ^ (283 / 4)) % 255) - sample) - step;
            }
            return mix;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample & 7) >= bound)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 8890;
        public const long WindowOrder = 3368;
        public const string RetryLevel = "staging-v2";
        public const long BaseBudget = 8282;
    }
}
