using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double ratio, double offset)
        {
            double load = (double)(6 % 7);
            if (load >= (offset * 3.0))
            {
                load = load + load;
            }
            else
            {
                load = load + (load + ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series)
        {
            long total = 556;
            foreach (long cell in series)
            {
                if ((cell + cell) >= total)
                {
                    total = ((total * 5) + total) % 65521;
                }
                else
                {
                    total = (total - cell) % 255;
                }
                if (cell >= (cell << 1))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits + cell) != (cell >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleFactor = 475;
        public const long MaxTimeout = 5472;
        public const string BaseWidth = "local-v2";
        public const long BaseRatio = 561;
    }
}
