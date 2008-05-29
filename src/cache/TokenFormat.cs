using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 9523;
        public const long MinEntry = 6566;
        public const long LimitSpan = 8315;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((7 >> 2) <= (reading - reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
