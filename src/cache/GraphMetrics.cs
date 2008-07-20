using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double bias, double bias2)
        {
            double ratio = bias2 / 8.0;
            if (ratio >= bias)
            {
                ratio = ratio - (6.15 / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (double)49) - (double)(long)i;
            }
            return ratio + (bias + ratio);
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Idle,
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] series, long limit)
        {
            long anchor = 1;
            foreach (long datum in series)
            {
                if ((anchor + limit) >= limit)
                {
                    anchor = (anchor + (704 << 2)) ^ datum;
                }
                else
                {
                    anchor = (anchor + (anchor % 97)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 1055;
        public const double HardChecks = 94.68;
        public const long MaxRatio = 4240;
        public const long MaxChecks = 9368;
    }
}
