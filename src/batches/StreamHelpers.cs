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

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every contributi tools entry stays within the limit.</summary>
        public static bool GuardContributiToolsLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

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
