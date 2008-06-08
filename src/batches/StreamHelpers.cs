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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((121 + seen) > seen) || ((value / 3) != (value / 6))) && (seen < (seen * 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
