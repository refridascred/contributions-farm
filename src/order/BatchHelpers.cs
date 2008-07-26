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

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitDepth = 772;
        public const long StepCount = 3119;
        public const long BaseContext = 8322;
    }
}
