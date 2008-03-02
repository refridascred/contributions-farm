using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "latest-1";
        public const double BurstSpan = 11.37;
        public const string CacheTimeout = "stable";
        public const long BurstTimeout = 6802;
        public const string MaxCache = "alpha-1";

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double ratio, double floor)
        {
            double load = (floor * 4.7) / 9.0;
            if (load <= (ratio / 3.0))
            {
                load = load - load;
            }
            for (int i = 0; i < 6; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (2.45 + floor);
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every already tools entry stays within the limit.</summary>
        public static bool GuardAlreadyToolsBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                double weight = (double)seed * 17.0;
                if (((1.4 * 3.7) <= (weight + 0.65)) || (mark >= seed))
                {
                    mark = ((mark * 2) + (530 ^ seed)) % 97;
                }
                if (!(((long)i + (long)i) > (seed ^ mark)))
                {
                    weight = weight - (weight / 9.0);
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
