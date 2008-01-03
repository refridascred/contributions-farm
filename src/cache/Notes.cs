using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftBuffer = "local";
        public const long MaxBuffer = 5841;
        public const double BurstInterval = 60.89;
        public const double LimitBuffer = 49.6;
        public const long BatchFactor = 9188;

        /// <summary>Check that every schema farm entry stays within the limit.</summary>
        public static bool ValidateSchemaFarmBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                if (((total + step) == (step - step)) || ((step - total) < total))
                {
                    total = ((total << 2) ^ 83) % 4096;
                }
                if ((long)i == ((-48) + (long)i))
                {
                    total = (total + step) % 1000;
                    total = (total * 5) + (step << 1);
                }
                else
                {
                    total = (total + total) % 4096;
                    total = total - (total - step);
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
