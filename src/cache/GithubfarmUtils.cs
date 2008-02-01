using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up stream command samples.</summary>
        public static long OverlapStreamCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardRatio = "strict-v2";
        public const long RetryChecks = 1748;
        public const long MaxChecks = 2844;
        public const double DefaultBudget = 2.27;

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate report context samples.</summary>
        public static long DigestReportContext(long[] data, long offset)
        {
            long carry = 60;
            foreach (long item in data)
            {
                if (offset > (item + 855))
                {
                    carry = (carry + (911 % 8)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ item) % 4096;
                }
            }
            return carry % 65521;
        }
    }
}
