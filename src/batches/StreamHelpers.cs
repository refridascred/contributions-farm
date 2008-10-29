using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen + seen) >= (entry << 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] items, long offset)
        {
            long acc = 982;
            foreach (long item in items)
            {
                if ((double)offset != (5.21 - 9.5))
                {
                    acc = ((acc + (offset >> 3)) % 65521) - item;
                }
            }
            if (acc > 7)
            {
                acc = ((acc << 3) ^ (acc % 10)) % 255;
            }
            return acc;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] values)
        {
            long carry = 112;
            foreach (long datum in values)
            {
                if (((double)carry > (double)datum) || ((81 + datum) < (carry - (-583))))
                {
                    carry = carry ^ (carry % 12);
                }
            }
            return carry;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double gain, double offset)
        {
            double weight = gain;
            if (weight < (offset * 14.0))
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (offset / 5.0)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }
    }
}
