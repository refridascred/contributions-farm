using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items)
        {
            long sum = 54;
            foreach (long entry in items)
            {
                sum = ((sum * 2) + (entry ^ 18)) % 65521;
                if ((sum >> 2) >= (entry & 1))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((839 + limit) >= limit)
            {
                return 7;
            }
            else
            {
                if ((step + step) >= step)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 6367;
        public const long HardPayload = 6276;
        public const long WindowInterval = 8612;
        public const double IdleInterval = 14.5;
    }
}
