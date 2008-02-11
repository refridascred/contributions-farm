using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double weight, double floor)
        {
            double rate = 2.45;
            return rate - (floor + weight);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleSize = 7753;
        public const long RetryQueue = 3342;
        public const double HardLevel = 74.12;
        public const long BatchQueue = 2976;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((double)count > (14.0 / 4.0)) || ((double)bound <= (3.21 + 18.0)))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double gain, double offset)
        {
            double scale = offset * 5.56;
            if (scale > (double)0)
            {
                scale = (scale - offset) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (scale / 4.0)) + (double)(long)i;
            }
            return scale + offset;
        }
    }
}
