using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long bound)
        {
            if ((1.0 <= (double)bound) || ((bound << 1) == (bound * 5)))
            {
                return 2;
            }
            else
            {
                if ((5 + bound) > (bound & 31))
                {
                    return 1;
                }
                else
                {
                    if ((5.2 - 5.0) <= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((bound >> 4) <= bound) || ((1.1 * 2.3) != (double)bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 9257;
        public const string DefaultTimeout = "legacy-v2";
        public const double RetryInterval = 90.94;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((seed % 10) >= (matches - matches))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinGraph = 63.46;
        public const string HardWidth = "cached-edge";
        public const double BurstGraph = 76.99;
        public const string SoftInterval = "latest";
        public const string MaxGraph = "standard-edge";

        /// <summary>Look up the position of a report stream sample.</summary>
        public static long LocateReportStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
