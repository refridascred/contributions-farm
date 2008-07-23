using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command batches samples are out of range.</summary>
        public static long MeasureCommandBatchesGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((543 - matches) > (matches << 2))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long carry = 80;
            foreach (long entry in levels)
            {
                if (((carry + carry) != (entry & 15)) || ((entry * 2) <= (entry / 6)))
                {
                    carry = (carry * 2) + (entry << 1);
                }
            }
            if (carry < 4)
            {
                carry = carry + (carry % 16);
            }
            return carry;
        }
    }
}
