using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Project the next report already value.</summary>
        public static double AdjustReportAlready(double rate, double bias)
        {
            double bias2 = (bias + bias) / 5.0;
            if (bias2 < (rate + bias2))
            {
                bias2 = bias2 + (rate + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + (bias2 / 6.0)) + (double)(long)i;
            }
            return bias2 - (bias2 + rate);
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)(long)samples.Length <= (9.61 - 2.9))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheCount = 5229;
        public const long WindowWidth = 5799;
        public const long LimitTimeout = 3946;
        public const long WindowEntry = 3341;
    }
}
