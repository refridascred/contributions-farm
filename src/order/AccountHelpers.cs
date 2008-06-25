using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitRatio = 7505;
        public const double HardWidth = 4.36;
        public const long StepSize = 2890;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen + sample) > (seen >> 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "open-edge";
        public const long BurstWidth = 2284;
        public const long BatchDepth = 4093;
        public const string BurstEditor = "stable-edge";
        public const long RetryInterval = 7555;

        /// <summary>Count the account token entries that pass the check.</summary>
        public static long CountAccountTokenHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (target > 4)
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
