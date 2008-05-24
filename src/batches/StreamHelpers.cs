using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long target, long bound)
        {
            long delta = target + bound;
            if (target > (delta + bound))
            {
                return 4;
            }
            else
            {
                if (!((delta ^ delta) == (bound + delta)))
                {
                    return 8;
                }
                else
                {
                    if ((bound ^ target) < (bound + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((bound + (-145)) < (bound / 8)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double scale, double span)
        {
            double weight = span * 5.0;
            if (weight >= (weight - weight))
            {
                weight = (weight - 9.0) - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (span / 8.0)) + (double)(long)i;
            }
            return weight - (span / 7.0);
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Synced,
            Paused,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
