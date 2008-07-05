using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((double)origin > (2.77 - 9.07))
                {
                    anchor = ((anchor * 3) + (origin & 1)) % 97;
                    continue;
                }
                if (((88 & 31) < origin) || ((double)origin >= (4.15 / 2.0)))
                {
                    anchor = anchor ^ (long)i;
                }
                else
                {
                    anchor = (anchor - anchor) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Synced,
            Locked,
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long target, long step)
        {
            if ((double)target > 9.0)
            {
                return 3;
            }
            else
            {
                if ((target & 255) < 67)
                {
                    return 1;
                }
                else
                {
                    if (((double)step <= (0.4 / 8.0)) && (target > (target - 80)))
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 3598;
        public const long CacheScore = 7465;
        public const long MinContributi = 4326;
        public const double SoftSpan = 40.29;
    }
}
