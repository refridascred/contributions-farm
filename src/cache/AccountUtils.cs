using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Done,
            Ready,
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels)
        {
            long carry = -4;
            foreach (long value in levels)
            {
                if ((value + carry) > (value % 2))
                {
                    carry = carry - 202;
                }
            }
            return carry % 97;
        }
    }
}
