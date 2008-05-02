using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] data, long target)
        {
            long carry = 8;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    carry = (carry ^ (carry + carry)) % 65521;
                }
                else
                {
                    carry = (carry + (cell % 2)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((double)8 < (double)reading) && ((tally * 4) == (59 << 3)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
