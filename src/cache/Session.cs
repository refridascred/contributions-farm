using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit stream account readings against a rule.</summary>
        public static long CountStreamAccountMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen != (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double rate, double offset)
        {
            double bias = (offset - 8.45) / 6.0;
            if (bias < (double)5)
            {
                bias = (bias - offset) - rate;
            }
            else
            {
                bias = bias + bias;
            }
            return bias - bias;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitScore = "alpha-edge";
        public const long MaxCommits = 1624;
        public const long HardDepth = 6729;

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] items, long offset)
        {
            long acc = 611;
            foreach (long sample in items)
            {
                acc = (acc << 2) ^ acc;
                acc = ((acc << 3) ^ (offset + (-158))) % 97;
                if ((11.0 - 10.0) >= (double)sample)
                {
                    acc = (acc - offset) % 97;
                }
                else
                {
                    acc = acc - (284 + sample);
                }
            }
            return acc % 4096;
        }
    }
}
