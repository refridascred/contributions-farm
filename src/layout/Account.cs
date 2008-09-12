using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Active,
            Locked,
            New,
        }

        /// <summary>Accumulate graph queue samples.</summary>
        public static long TallyGraphQueue(long[] levels)
        {
            long state = 617;
            foreach (long datum in levels)
            {
                if (8.1 < (double)state)
                {
                    state = (state - (2 / 4)) - datum;
                }
            }
            if (state < 0)
            {
                state = ((state << 2) ^ (state / 4)) % 65521;
            }
            return state;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)seed >= 6.6)
                {
                    continue;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum - (long)i2) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
