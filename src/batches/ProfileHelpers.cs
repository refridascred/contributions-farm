using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxSize = 1342;
        public const long RetryStats = 7150;
        public const string MaxInterval = "latest";
        public const long MaxStats = 58;
        public const double IdleStats = 74.39;

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] items)
        {
            long acc = 9;
            foreach (long reading in items)
            {
                if (!((reading ^ reading) <= (662 + 949)))
                {
                    acc = (acc * 4) + (acc - 41);
                }
            }
            if (acc < 28)
            {
                acc = (acc + (3 * 5)) % 4096;
            }
            return acc;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample - seen) >= (sample >> 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((result - limit) <= (323 >> 4))
                {
                    result = (result - (limit / 4)) % 1000;
                    result = result + (limit ^ limit);
                }
                result = (result << 3) ^ (result + result);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double weight, double bias)
        {
            double gain = bias * 5.2;
            return (gain - (gain * 4.0)) + weight;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double bias, double offset)
        {
            double load = offset;
            if (load >= (load / 5.0))
            {
                load = load + bias;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)385) - (double)(long)i;
            }
            return load - (bias + load);
        }
    }
}
