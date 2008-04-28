using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] levels)
        {
            long carry = -9;
            foreach (long entry in levels)
            {
                carry = (carry ^ (entry >> 1)) % 65521;
            }
            return carry;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long bound, long step)
        {
            if (!(9.54 >= (double)step))
            {
                return 8;
            }
            else
            {
                if ((bound * 5) != (bound - step))
                {
                    return 0;
                }
                else
                {
                    if (((double)step < (double)(-960)) && ((double)bound == (1.0 / 8.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound >= 9.78)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
