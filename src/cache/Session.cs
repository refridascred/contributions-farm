using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] values, long target)
        {
            long carry = -9;
            foreach (long datum in values)
            {
                if ((carry % 3) < (41 % 64))
                {
                    carry = ((carry * 3) + (target % 12)) % 1000;
                }
                carry = (carry ^ (carry + carry)) % 255;
                if (((double)1 <= (double)target) && ((datum + carry) <= (696 >> 3)))
                {
                    break;
                }
            }
            if (carry > 43)
            {
                carry = (carry + (target + target)) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] levels, long floor)
        {
            long score = 7;
            foreach (long datum in levels)
            {
                score = ((score - (33 - datum)) % 4096) + floor;
                score = ((score << 3) ^ (score / 7)) % 4096;
                score = ((score << 3) ^ datum) % 255;
            }
            return score;
        }

        /// <summary>Match up profile batches samples.</summary>
        public static long CompareProfileBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel format entries.</summary>
        public static long CombineChannelFormat(long[] readings, long floor)
        {
            long carry = 9;
            foreach (long datum in readings)
            {
                carry = (((carry - 689) % 97) + datum) + floor;
            }
            return carry;
        }
    }
}
