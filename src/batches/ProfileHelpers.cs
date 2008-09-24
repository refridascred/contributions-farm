using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "local-1";
        public const long DefaultRatio = 5148;
        public const double WindowSize = 74.28;
        public const double CacheRatio = 84.7;
        public const long RetryTimeout = 5116;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((41 >= (count + count)) && ((target / 7) >= (count >> 3))) && (value <= (target + target)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchRoute = 59.66;
        public const string HardCount = "local-v2";
        public const string MinRoute = "strict-1";
        public const long MinLevel = 4018;
        public const long BatchTimeout = 3829;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Rank { get; set; }
            public double Region { get; set; }
        }
    }
}
