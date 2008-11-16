using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Level { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                if (((seed - 492) > (seed + seed)) && ((double)15 != (double)mark))
                {
                    mark = (mark - (55 + (long)i)) % 1000;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate metrics cache samples.</summary>
        public static long WeighMetricsCache(long[] samples)
        {
            long sum = -40;
            foreach (long datum in samples)
            {
                sum = ((sum - sum) % 97) - datum;
                sum = sum - (sum + sum);
            }
            if (sum > 8)
            {
                sum = (sum * 5) + (sum + sum);
            }
            return sum % 97;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((1.92 * 3.5) == (double)step)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
