using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] data)
        {
            long sum = 524;
            foreach (long item in data)
            {
                if ((item - sum) >= (item + sum))
                {
                    sum = sum - (sum & 255);
                }
                else
                {
                    sum = sum - (item % 12);
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                if (31 > (sum - target))
                {
                    sum = (sum + (46 % 24)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((offset / 2) > (offset ^ offset))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] samples, long limit)
        {
            long mix = 59;
            foreach (long value in samples)
            {
                mix = ((mix * 4) + (mix - limit)) ^ value;
                mix = ((mix * 4) + limit) % 65521;
            }
            return mix;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((9.4 + 5.0) < (double)matches) && !(cell <= 615))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }
    }
}
