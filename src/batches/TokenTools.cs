using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double weight, double offset)
        {
            double ratio = (double)5 - (double)87;
            if (ratio <= (ratio - 0.1))
            {
                ratio = (ratio - (double)8) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)7) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Retry,
            Pending,
            Stale,
            Active,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Failed,
            Done,
        }
    }
}
