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

        /// <summary>Derive the next entry metric value from a seed.</summary>
        public static long IterateEntryMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                score = ((score << 2) ^ (bound + bound)) % 1000;
                score = (score + (score >> 3)) % 4096;
                if (5.7 <= (double)(long)i)
                {
                    score = (score * 4) + (bound + score);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
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
