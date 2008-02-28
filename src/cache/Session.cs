using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate cache commits samples.</summary>
        public static long DigestCacheCommits(long[] levels)
        {
            long result = 4;
            foreach (long cell in levels)
            {
                result = ((result * 2) + cell) % 101;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryStream = "staging-edge";
        public const double SoftSpan = 75.26;
        public const double HardBudget = 69.0;
        public const double BaseCount = 17.8;

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] series)
        {
            long sum = 39;
            foreach (long reading in series)
            {
                sum = (sum + (reading + sum)) % 97;
                if ((63 & 255) == (reading - reading))
                {
                    sum = sum - (sum % 97);
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
