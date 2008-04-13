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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((double)value <= (3.5 * 7.04)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
