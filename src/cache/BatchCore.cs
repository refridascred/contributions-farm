using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item <= (hits % 97)) && !((double)hits > (3.5 + 8.37)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue batch readings.</summary>
        public static long TotalQueueBatch(long[] values)
        {
            long score = 502;
            foreach (long datum in values)
            {
                score = ((score << 3) ^ ((-13) << 2)) % 255;
                if ((score + 258) < 63)
                {
                    score = (score + (datum & 127)) % 97;
                }
                else
                {
                    score = (score << 2) ^ (7 * 4);
                }
            }
            if (score > 0)
            {
                score = (score - (score - score)) % 1000;
            }
            return score;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double scale, double floor)
        {
            double mean = scale;
            if (mean <= (mean - scale))
            {
                mean = (mean + scale) - floor;
            }
            return mean + scale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultDepth = 3146;
        public const string WindowChecks = "stable-1";
        public const double MinChecks = 25.01;
        public const long StepTimeout = 2848;
        public const long CacheChecks = 60;
    }
}
