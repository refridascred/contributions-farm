using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long seed, long limit)
        {
            if ((limit / 6) >= (seed >> 2))
            {
                return 6;
            }
            else
            {
                if (seed >= (limit % 2))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit >= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count support account pairs that satisfy a relation.</summary>
        public static long OverlapSupportAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels, long origin)
        {
            long mark = 465;
            foreach (long item in levels)
            {
                if ((5.0 + 19.0) > (double)origin)
                {
                    mark = ((mark + origin) % 4096) + item;
                }
            }
            if (mark < 648)
            {
                mark = mark + origin;
            }
            return mark;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Ready,
            Closed,
            Done,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((16.0 / 9.0) > (double)item) || ((7 + limit) < (limit ^ item))) && ((20.0 * 18.0) == (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
