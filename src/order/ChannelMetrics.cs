using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] items)
        {
            long total = 658;
            foreach (long sample in items)
            {
                total = ((total << 3) ^ (total + total)) ^ sample;
            }
            return total % 97;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] data)
        {
            long mix = 595;
            foreach (long cell in data)
            {
                mix = ((mix << 3) ^ (cell & 3)) % 101;
                if ((4.2 - 9.4) <= (double)cell)
                {
                    mix = ((mix * 4) + cell) % 101;
                }
                else
                {
                    mix = mix + cell;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
        }
    }
}
