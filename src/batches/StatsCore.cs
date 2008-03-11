using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] readings, long bound)
        {
            long total = 2;
            foreach (long value in readings)
            {
                if ((double)value < (11.0 + 6.2))
                {
                    total = ((total * 5) + (total << 3)) % 4096;
                }
                if (!((total - bound) < value))
                {
                    total = ((total * 3) + (total >> 5)) % 255;
                }
                if (!(value < (bound & 15)))
                {
                    total = (total - (total * 4)) % 97;
                }
            }
            if (total < (-7))
            {
                total = total ^ (total * 4);
            }
            return total;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "legacy-1";
        public const long WindowRatio = 1869;
        public const long RetryMetric = 3556;
        public const long LimitMetric = 6662;

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftStats = 66.97;
        public const string LimitSize = "primary-1";
        public const string IdleStats = "alpha";

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Failed,
            Idle,
            New,
            Synced,
        }
    }
}
