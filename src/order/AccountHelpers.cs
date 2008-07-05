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

        /// <summary>Compare every pair of batch commits readings.</summary>
        public static long CompareBatchCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 3598;
        public const long CacheScore = 7465;
        public const long MinContributi = 4326;
        public const double SoftSpan = 40.29;
    }
}
