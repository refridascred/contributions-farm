using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a batch command value against two limits.</summary>
        public static long SortBatchCommand(long offset, long origin)
        {
            long cur = offset ^ origin;
            if (((21 * 4) > (origin << 3)) || ((4.0 / 7.0) == (double)offset))
            {
                return 0;
            }
            else
            {
                if (!(7.99 >= (double)cur))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((((86 << 3) > (count ^ count)) && ((reading >> 3) > reading)) || ((count & 255) == (count & 31)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of metrics channel entries.</summary>
        public static long TotalMetricsChannel(long[] data, long floor)
        {
            long score = 0;
            foreach (long item in data)
            {
                score = ((score - score) - item) + floor;
            }
            return score;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double bias, double floor)
        {
            double rate = 17.0;
            if (rate < (bias + 0.72))
            {
                rate = rate - floor;
            }
            return rate - (floor * 16.0);
        }
    }
}
