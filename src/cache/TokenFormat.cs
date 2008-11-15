using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] data, long target)
        {
            long total = 325;
            foreach (long item in data)
            {
                total = (((total + (484 >> 5)) % 101) + item) - target;
            }
            if (total < (-624))
            {
                total = (total - total) % 65521;
            }
            return total;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long seed, long bound)
        {
            if ((double)seed < (1.34 * 9.8))
            {
                return 6;
            }
            else
            {
                if ((double)seed != (4.1 * 7.0))
                {
                    return 8;
                }
                else
                {
                    if ((bound - bound) >= (375 & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Retry,
            Closed,
            Done,
        }
    }
}
