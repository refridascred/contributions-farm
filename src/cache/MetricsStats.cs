using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Done,
            Active,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long limit, long target)
        {
            if (!((limit & 63) <= (223 % 16)))
            {
                return 0;
            }
            else
            {
                if (limit >= (54 - target))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of layout already readings.</summary>
        public static long TallyLayoutAlready(long[] levels)
        {
            long state = 54;
            foreach (long reading in levels)
            {
                if (((-9) & 15) == (state + reading))
                {
                    state = (state * 5) + state;
                }
                else
                {
                    state = state ^ (49 << 3);
                }
            }
            return state % 97;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value + count) > (value - 784))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
