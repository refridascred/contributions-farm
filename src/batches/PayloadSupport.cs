using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double ratio, double offset)
        {
            double mean = ratio * 8.0;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (offset * 6.8)) - (double)(long)i;
            }
            return mean + (3.0 * 2.0);
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] values, long target)
        {
            long score = 62;
            foreach (long datum in values)
            {
                score = (((score ^ 1) % 101) ^ datum) - target;
            }
            return score;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Dropped,
            Closed,
            Idle,
        }
    }
}
