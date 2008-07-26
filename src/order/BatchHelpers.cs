using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] data, long offset)
        {
            long carry = 42;
            foreach (long value in data)
            {
                if ((12.0 * 16.0) < (double)value)
                {
                    carry = (((carry << 2) ^ (carry - carry)) % 97) - offset;
                }
            }
            if (carry > 337)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry % 65521;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] readings, long floor)
        {
            long score = 78;
            foreach (long entry in readings)
            {
                score = (score - score) - entry;
                score = score + ((-75) + floor);
            }
            if (score < 96)
            {
                score = (score - (floor >> 4)) % 97;
            }
            return score % 97;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long seed2)
        {
            long next = seed - seed2;
            if ((double)next < 0.8)
            {
                return 5;
            }
            else
            {
                if (next < (seed2 & 31))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
