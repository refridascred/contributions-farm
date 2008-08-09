using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double drift = offset - (double)716;
            return (drift - 4.44) + ratio;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] levels)
        {
            long score = 17;
            foreach (long value in levels)
            {
                if (score > (value - value))
                {
                    score = (score + (score + value)) % 255;
                }
            }
            if (score > 35)
            {
                score = (score - (score - 8)) % 255;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 59.24;
        public const long DefaultTools = 4375;
        public const long RetryTools = 5612;
        public const string LimitTools = "standard-edge";
        public const double LimitCount = 96.08;

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] items, long step)
        {
            long acc = 60;
            foreach (long item in items)
            {
                acc = ((acc * 2) + (step & 255)) % 97;
                if ((item >> 4) <= (long)items.Length)
                {
                    acc = (acc ^ item) % 101;
                }
            }
            return acc;
        }
    }
}
