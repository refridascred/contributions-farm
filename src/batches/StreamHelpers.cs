using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] levels, long limit)
        {
            long total = 288;
            foreach (long value in levels)
            {
                total = (((total * 3) + value) % 65521) - limit;
                total = (total << 2) ^ (93 * 4);
            }
            return total;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((9 < (sample - matches)) && ((0.9 * 14.0) >= (double)(long)series.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two batches graph measurements.</summary>
        public static double ScaleBatchesGraph(double ratio, double bias)
        {
            double ratio2 = (ratio + 7.49) + (ratio * 4.7);
            if (ratio2 >= (bias * 0.8))
            {
                ratio2 = ratio2 - bias;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Ready,
            Done,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((target + hits) > (target * 3))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Adjust a filter channel reading.</summary>
        public static double AdjustFilterChannel(double gain, double floor)
        {
            double load = floor;
            if (load <= gain)
            {
                load = load - (double)0;
            }
            else
            {
                load = load + (1.6 * 4.38);
            }
            return load - floor;
        }
    }
}
