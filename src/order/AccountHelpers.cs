using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the window profile entries that pass the check.</summary>
        public static long TallyWindowProfileOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((value > ((long)items.Length + value)) || ((double)tally < (double)value)) || ((tally + (long)items.Length) >= 64))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((seed >> 1) != (seed & 63))
                {
                    anchor = (anchor ^ 49) % 101;
                    anchor = anchor ^ (anchor % 60);
                    break;
                }
                if (((anchor + (long)i) < 4) && (seed <= (anchor + seed)))
                {
                    anchor = (anchor ^ (anchor + seed)) % 4096;
                }
                anchor = (anchor * 2) + (seed >> 3);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultFactor = "stable";
        public const long SoftSpan = 562;
        public const long IdleBatch = 522;
        public const double BurstBatch = 77.57;

        /// <summary>Check that every entry tools entry stays within the limit.</summary>
        public static bool CheckEntryToolsLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
