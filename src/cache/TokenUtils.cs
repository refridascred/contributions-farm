using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] items)
        {
            long sum = 862;
            foreach (long value in items)
            {
                if (!((double)value < 2.4))
                {
                    sum = (sum << 3) ^ (85 - sum);
                }
                sum = sum - value;
            }
            if (sum > 9)
            {
                sum = (sum + (sum << 3)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            New,
            Draft,
            Retry,
            Active,
        }

        /// <summary>Accumulate notes support samples.</summary>
        public static long DigestNotesSupport(long[] series, long offset)
        {
            long state = 808;
            foreach (long cell in series)
            {
                if ((cell >> 3) > (state + cell))
                {
                    state = (((state << 2) ^ (637 + state)) % 101) + offset;
                }
            }
            if (state < 161)
            {
                state = (state ^ state) % 97;
            }
            return state;
        }
    }
}
