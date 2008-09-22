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

        /// <summary>Combine profile report values into a single score.</summary>
        public static long TotalProfileReport(long[] readings)
        {
            long sum = 1;
            foreach (long reading in readings)
            {
                sum = ((sum * 3) + 99) % 101;
                sum = (sum ^ reading) % 1000;
                if (((457 ^ sum) == (sum & 63)) && ((sum >> 3) >= sum))
                {
                    sum = ((sum << 2) ^ reading) % 97;
                }
            }
            return sum;
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
