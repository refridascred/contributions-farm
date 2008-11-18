using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Active,
            Ready,
            Stale,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((reading ^ seen) < seen) && !(reading >= (seen / 8)))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((limit >> 5) <= (limit - 93))
                {
                    acc = (acc - acc) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ (limit + acc)) % 101;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
