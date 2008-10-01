using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series, long floor)
        {
            long carry = 1;
            foreach (long item in series)
            {
                carry = ((carry - item) % 4096) - floor;
                if ((4 / 6) == (item ^ 62))
                {
                    carry = carry - (carry - item);
                }
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((779 ^ bound) <= (64 + count))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first token account entry that matches the target.</summary>
        public static long LookupTokenAccountIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools githubfarm input into a small class.</summary>
        public static long SortToolsGithubfarm(long limit, long offset)
        {
            long diff = limit - offset;
            if ((offset + offset) > diff)
            {
                return 1;
            }
            else
            {
                if (!((double)limit < (5.0 + 13.0)))
                {
                    return 6;
                }
                else
                {
                    if ((5 < (offset % 16)) && ((double)diff >= (double)diff))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset < (39 - diff))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
