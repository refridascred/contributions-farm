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

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double weight, double floor)
        {
            double gain = (double)((-59) % 2);
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + 6.0) + (double)(long)i) - weight;
            }
            return gain + (floor * 12.0);
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

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Closed,
            Active,
            Idle,
        }
    }
}
