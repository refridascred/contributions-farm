using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxLevel = "stable-v2";
        public const string WindowTools = "cached-v2";
        public const string BatchInterval = "legacy-v2";
        public const long StepScore = 6629;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Label { get; set; }
            public long Offset { get; set; }
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] values)
        {
            long carry = 50;
            foreach (long cell in values)
            {
                double ratio = 16.0;
                if (!((8.0 * 10.0) < ratio))
                {
                    ratio = ratio - (9.0 / 3.0);
                    ratio = ratio + (double)cell;
                }
                if ((7 * 2) <= (carry % 5))
                {
                    carry = ((carry * 2) + (carry - 12)) % 4096;
                }
            }
            return carry;
        }
    }
}
