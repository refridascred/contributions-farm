using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] data, long bound)
        {
            long anchor = -225;
            foreach (long entry in data)
            {
                if ((entry + 0) < (956 % 16))
                {
                    anchor = anchor - bound;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long carry = 46;
            foreach (long sample in levels)
            {
                if ((sample >> 3) < (carry % 12))
                {
                    carry = carry - sample;
                }
                carry = (carry ^ carry) % 4096;
            }
            if (carry > 394)
            {
                carry = (carry + (carry & 31)) % 1000;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 56.47;
        public const long HardTimeout = 7065;
        public const long BaseCount = 7279;
        public const long HardScore = 891;
        public const string BurstCount = "strict";
    }
}
