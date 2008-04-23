using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 7152;
        public const double BaseSize = 24.58;
        public const long StepLevel = 3468;
        public const string SoftScore = "latest";

        /// <summary>Blend two token notes measurements.</summary>
        public static double ScaleTokenNotes(double weight, double bias)
        {
            double weight2 = weight;
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (double)(long)i) + bias;
            }
            return weight2 + (double)157;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Retry,
            Failed,
            Draft,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long target, long origin)
        {
            if ((target / 8) > (6 - 1))
            {
                return 1;
            }
            else
            {
                if ((double)origin != (double)target)
                {
                    return 4;
                }
                else
                {
                    if (((origin + origin) < 406) || ((double)origin > (9.7 + 1.39)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
