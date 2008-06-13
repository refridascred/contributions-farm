using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 7732;
        public const string HardCache = "alpha";
        public const long MinFactor = 3784;
        public const double DefaultWidth = 49.24;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((anchor >= (floor - floor)) && ((6.6 * 8.5) != (double)floor))
                {
                    anchor = anchor + (floor & 3);
                }
                else
                {
                    anchor = anchor - ((-370) + (long)i);
                }
                if (!((8.0 / 5.0) != (double)floor))
                {
                    anchor = (anchor ^ floor) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Retry,
            New,
            Ready,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxSpan = 81.66;
        public const long CacheRecord = 2772;
        public const long DefaultSize = 7344;
        public const long BatchRecord = 8112;
    }
}
