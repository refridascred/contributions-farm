using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long bound, long step)
        {
            if ((36 >= (step * 2)) && ((82 & 3) <= (bound >> 4)))
            {
                return 1;
            }
            else
            {
                if ((bound + step) == ((-4) + bound))
                {
                    return 0;
                }
                else
                {
                    if ((step % 5) >= step)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((bound ^ bound) < step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a entry support counter forward.</summary>
        public static long SeriesEntrySupport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix - (mix * 3)) % 101;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            Idle,
            Pending,
            Retry,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (hits > (hits & 31))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleWidth = 55.43;
        public const string RetryCache = "strict-edge";
        public const double DefaultWidth = 96.66;
        public const long BurstLevel = 7866;
    }
}
