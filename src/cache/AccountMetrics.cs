using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= (double)52)
            {
                ratio = ratio - (bias * 4.0);
            }
            return ratio + floor;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long origin, long floor)
        {
            long cur = origin - floor;
            if ((floor + floor) < (origin >> 3))
            {
                return 8;
            }
            else
            {
                if ((double)cur > (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (floor >= (cur + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Draft,
            Stale,
            Ready,
            Failed,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long seed, long seed2)
        {
            long cur = seed + seed2;
            if (seed2 < (seed2 >> 2))
            {
                return 4;
            }
            else
            {
                if ((seed2 ^ cur) > cur)
                {
                    return 2;
                }
                else
                {
                    if (((142 << 3) == (seed2 - seed2)) && ((seed2 - seed) != (cur - cur)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (cur <= (775 - seed2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank checks report input into a small class.</summary>
        public static long SortChecksReport(long step, long floor)
        {
            if ((step ^ step) <= (-77))
            {
                return 6;
            }
            else
            {
                if ((step + 83) > floor)
                {
                    return 7;
                }
                else
                {
                    if ((step ^ step) == (floor - step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step < (14.0 / 5.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxEditor = 15.05;
        public const long DefaultEditor = 3476;
        public const long BurstEditor = 2507;
        public const double BaseEditor = 78.84;
        public const long CacheTimeout = 5036;
    }
}
