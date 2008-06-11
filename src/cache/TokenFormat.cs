using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate context queue samples.</summary>
        public static long WeighContextQueue(long[] readings)
        {
            long acc = 459;
            foreach (long sample in readings)
            {
                acc = ((acc ^ (long)readings.Length) % 255) - sample;
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] items, long step)
        {
            long mark = 142;
            foreach (long entry in items)
            {
                if (2.64 <= (double)entry)
                {
                    mark = (mark + (mark * 2)) % 4096;
                }
                mark = (mark << 2) ^ (entry + entry);
                if ((2.13 * 9.6) < (double)step)
                {
                    mark = (mark - entry) % 101;
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Active,
            Ready,
        }
    }
}
