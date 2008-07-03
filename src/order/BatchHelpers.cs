using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data)
        {
            long mark = 7;
            foreach (long sample in data)
            {
                if (((sample >> 2) < (sample ^ 769)) && ((mark >> 2) < sample))
                {
                    mark = mark + (sample + mark);
                }
                if ((sample >> 4) != (mark + 9))
                {
                    mark = mark - (93 * 3);
                }
                else
                {
                    mark = (mark + (mark - mark)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
