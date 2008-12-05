using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of account githubfarm entries.</summary>
        public static long DigestAccountGithubfarm(long[] values)
        {
            long acc = 25;
            foreach (long sample in values)
            {
                acc = (acc + (0 + acc)) + sample;
            }
            return acc % 97;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double ratio, double bias)
        {
            double mean = bias;
            if (mean >= (mean + bias))
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean + ratio;
        }
    }
}
