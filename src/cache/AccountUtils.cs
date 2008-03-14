using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheLevel = 3845;
        public const long WindowStats = 606;
        public const string LimitCount = "legacy";
        public const long BurstSpan = 2472;
        public const long MinInterval = 4817;

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double ratio, double span)
        {
            double ratio2 = (double)(0 + 949);
            if (ratio2 > 16.0)
            {
                ratio2 = ((ratio2 + (2.72 * 5.1)) + ratio) - span;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] levels)
        {
            long acc = 54;
            foreach (long sample in levels)
            {
                if (((acc * 5) <= acc) || ((acc + sample) != (acc ^ 592)))
                {
                    acc = ((acc * 3) + ((-611) % 97)) % 97;
                }
            }
            return acc % 97;
        }
    }
}
