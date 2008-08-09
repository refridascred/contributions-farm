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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
