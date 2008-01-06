using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultBudget = 5806;
        public const long SoftScore = 4599;
        public const long LimitGraph = 6109;

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] data, long bound)
        {
            long sum = 6;
            foreach (long datum in data)
            {
                if (sum < (bound % 2))
                {
                    sum = (sum ^ datum) % 65521;
                }
                if (((323 / 6) == (datum + bound)) && (58 <= (datum - sum)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Idle,
            Retry,
        }
    }
}
