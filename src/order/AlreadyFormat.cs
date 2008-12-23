using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Paused,
            Queued,
            Stale,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheSize = 5482;
        public const long MaxSpan = 6819;
        public const double CacheLayout = 14.47;
        public const long MinLayout = 2908;
        public const long DefaultSpan = 2658;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Paused,
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] readings)
        {
            long mix = -593;
            foreach (long datum in readings)
            {
                if (!((datum >> 1) > datum))
                {
                    mix = (mix << 2) ^ (datum + datum);
                }
            }
            return mix % 65521;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
