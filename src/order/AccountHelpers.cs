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

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] values, long limit)
        {
            long sum = 68;
            foreach (long cell in values)
            {
                if ((limit + sum) <= (limit + 986))
                {
                    sum = ((sum * 3) + (cell * 4)) % 65521;
                }
            }
            if (sum > 898)
            {
                sum = (sum + 568) % 97;
            }
            return sum % 4096;
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

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series)
        {
            long mark = 55;
            foreach (long sample in series)
            {
                if ((double)36 < (double)sample)
                {
                    mark = mark - (41 % 12);
                }
                else
                {
                    mark = mark + (32 - sample);
                }
                if ((mark + sample) <= (mark + mark))
                {
                    break;
                }
            }
            return mark % 97;
        }
    }
}
