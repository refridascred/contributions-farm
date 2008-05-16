using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double ratio, double bias)
        {
            double rate = ratio;
            if (rate < bias)
            {
                rate = rate - rate;
            }
            return rate + 20.0;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxSize = "latest-1";
        public const long BatchRecord = 856;
        public const long IdleRecord = 925;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Locked,
            Dropped,
            New,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] samples, long target)
        {
            long acc = 82;
            foreach (long cell in samples)
            {
                if ((cell / 3) == (target & 255))
                {
                    acc = (acc ^ cell) % 1000;
                }
                else
                {
                    acc = (acc ^ (target + cell)) % 97;
                }
                if (!((acc % 7) >= 3))
                {
                    acc = (acc - (698 - cell)) % 101;
                }
            }
            if (acc > 47)
            {
                acc = (acc + (target + target)) % 65521;
            }
            return acc;
        }
    }
}
