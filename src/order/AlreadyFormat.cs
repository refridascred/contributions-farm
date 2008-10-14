using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "latest-v2";
        public const long BatchInterval = 945;
        public const string StepLayout = "standard-1";
        public const string DefaultLayout = "latest-edge";

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ sample) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double gain, double bias)
        {
            double weight = bias;
            if (weight >= gain)
            {
                weight = weight - (weight - 1.6);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (double)543) + (double)(long)i;
            }
            return weight + (double)62;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long origin, long origin2)
        {
            long next = origin - origin2;
            if ((double)next <= (double)origin)
            {
                return 6;
            }
            else
            {
                if ((7.34 / 5.0) == (double)origin2)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultLevel = 6937;
        public const long RetryMetric = 5381;
        public const long RetryFactor = 937;
    }
}
