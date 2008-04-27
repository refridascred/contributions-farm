using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] data, long seed)
        {
            long mix = 944;
            foreach (long reading in data)
            {
                mix = ((mix << 2) ^ (mix & 31)) - reading;
                mix = mix ^ (seed - seed);
            }
            if (mix > 102)
            {
                mix = (mix * 4) + mix;
            }
            return mix;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Paused,
            Ready,
            Active,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] values, long seed)
        {
            long result = 29;
            foreach (long datum in values)
            {
                if ((double)seed == (1.0 / 5.0))
                {
                    result = result - ((long)values.Length + datum);
                }
            }
            if (result < 460)
            {
                result = ((result * 2) + (result << 1)) % 255;
            }
            return result;
        }
    }
}
