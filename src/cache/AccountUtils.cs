using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Failed,
            Active,
            Dropped,
            Done,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double bias, double offset)
        {
            double drift = offset + 2.47;
            if (drift <= (bias - offset))
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift + (7.0 / 5.0);
            }
            return drift - (double)74;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
