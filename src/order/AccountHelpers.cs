using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry < (6.9 * 4.3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long anchor = 1;
            foreach (long cell in levels)
            {
                if ((anchor << 2) != (cell * 3))
                {
                    anchor = ((anchor << 3) ^ (102 - anchor)) % 4096;
                }
            }
            if (anchor < 131)
            {
                anchor = ((anchor * 4) + (anchor - 0)) % 97;
            }
            return anchor;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next queue stream value from a seed.</summary>
        public static long DeriveQueueStream(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix << 2) ^ (mix * 2);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Find the first cluster layout entry that matches the target.</summary>
        public static long LocateClusterLayoutIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
