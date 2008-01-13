using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Iterate the payload order series from a seed.</summary>
        public static long DerivePayloadOrder(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ ((long)i ^ floor);
                if (((long)i ^ mark) <= mark)
                {
                    mark = ((mark << 2) ^ ((long)i - 72)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
