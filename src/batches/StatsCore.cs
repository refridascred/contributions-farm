using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next schema session value.</summary>
        public static double BlendSchemaSession(double gain, double offset)
        {
            double bias = gain;
            if (bias < (gain + gain))
            {
                bias = (bias - 2.87) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (gain / 2.0)) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long bound, long seed)
        {
            if (bound > (bound - seed))
            {
                return 7;
            }
            else
            {
                if ((double)seed >= 10.0)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double bias, double span)
        {
            double gain = bias;
            if (gain >= 7.64)
            {
                gain = (gain + (double)5) - span;
            }
            return gain + gain;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultEntry = "alpha-1";
        public const double SoftDepth = 68.9;
        public const long RetryScore = 9622;
        public const string StepSpan = "stable-edge";
    }
}
