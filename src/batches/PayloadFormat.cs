using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a session metric figure with a bias.</summary>
        public static double SmoothSessionMetric(double weight, double bias)
        {
            double load = (double)((-70) + 9);
            if (load <= load)
            {
                load = (load - (double)7) + weight;
            }
            else
            {
                load = load - load;
            }
            return load - (bias - load);
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every tools cache entry stays within the limit.</summary>
        public static bool GuardToolsCacheLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleDepth = 9765;
        public const string StepSession = "cached-edge";
        public const long BaseSpan = 8593;
        public const long MinSession = 7005;
    }
}
