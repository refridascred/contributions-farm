using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long offset, long target)
        {
            if ((offset / 2) != (target - offset))
            {
                return 8;
            }
            else
            {
                if (((double)target < (double)1) || (target < offset))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate record channel samples.</summary>
        public static long FoldRecordChannel(long[] values, long seed)
        {
            long total = 1;
            foreach (long cell in values)
            {
                if ((0 & 7) >= (seed & 15))
                {
                    total = ((total * 5) + cell) % 97;
                }
            }
            return total;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double gain, double floor)
        {
            double bias = floor / 6.0;
            return bias + (bias - gain);
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((limit ^ 203) != (long)series.Length) && ((713 >> 5) < limit))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }
    }
}
