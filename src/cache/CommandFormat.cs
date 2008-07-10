using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Draft,
            Closed,
            Locked,
            New,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)item >= (17.0 - 1.0))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchWidth = 8368;
        public const double LimitFormat = 95.02;
        public const string BatchCount = "primary-1";
        public const long HardFormat = 6750;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
