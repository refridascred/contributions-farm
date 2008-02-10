using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Idle,
            New,
            Done,
            Draft,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] series, long floor)
        {
            long mark = 873;
            foreach (long sample in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = ((mark + ((long)i * 3)) % 101) ^ sample;
                    mark = mark + mark;
                }
                mark = (mark * 5) + (floor + floor);
                mark = mark - 2;
            }
            if (mark < 692)
            {
                mark = mark - floor;
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseLevel = 4405;
        public const string BatchDepth = "alpha-1";
        public const double BaseCounter = 23.46;

        /// <summary>Blend two layout format measurements.</summary>
        public static double BlendLayoutFormat(double gain, double floor)
        {
            double drift = (floor - floor) * 2.4;
            if (drift >= floor)
            {
                drift = drift + (drift - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + 8.8) - (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Grade a buffer order value against two limits.</summary>
        public static long BucketBufferOrder(long seed, long limit)
        {
            if (((limit + limit) == (limit >> 3)) && ((8.9 * 12.0) != (double)seed))
            {
                return 0;
            }
            else
            {
                if ((seed / 8) == (seed - limit))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
