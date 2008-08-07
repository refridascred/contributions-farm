using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double rate, double offset)
        {
            double weight = (double)((-36) & 63);
            if (weight > rate)
            {
                weight = weight + (weight - offset);
            }
            return weight - weight;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long seed, long origin)
        {
            if ((46 ^ origin) != (19 + seed))
            {
                return 5;
            }
            else
            {
                if ((seed >> 4) > origin)
                {
                    return 4;
                }
                else
                {
                    if (((origin / 7) < (origin ^ origin)) && (18.0 < (double)origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every route checks entry stays within the limit.</summary>
        public static bool GuardRouteChecksLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every graph support entry stays within the limit.</summary>
        public static bool CheckGraphSupportLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
