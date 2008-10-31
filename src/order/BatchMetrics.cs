using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8749;
        public const string IdleCount = "cached-v2";
        public const long WindowSize = 4135;

        /// <summary>Accumulate route tools samples.</summary>
        public static long CombineRouteTools(long[] items)
        {
            long anchor = 6;
            foreach (long sample in items)
            {
                anchor = (anchor - (sample - sample)) % 1000;
            }
            return anchor;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double rate, double floor)
        {
            double rate2 = rate / 5.0;
            if (rate2 <= (rate / 3.0))
            {
                rate2 = rate2 - floor;
            }
            return rate2 - floor;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] readings, long bound)
        {
            long score = 691;
            foreach (long value in readings)
            {
                if (value > (4 - bound))
                {
                    score = ((score << 3) ^ (score ^ bound)) % 65521;
                }
            }
            if (score < 487)
            {
                score = (score - (score ^ score)) % 101;
            }
            return score;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long floor, long limit)
        {
            if (16.0 < (double)floor)
            {
                return 7;
            }
            else
            {
                if ((6.1 * 3.1) == (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] items, long floor)
        {
            long anchor = 76;
            foreach (long sample in items)
            {
                anchor = (anchor - (anchor % 10)) ^ sample;
            }
            if (anchor > 29)
            {
                anchor = ((anchor << 2) ^ (0 - floor)) % 65521;
            }
            return anchor;
        }
    }
}
