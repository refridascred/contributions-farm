using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next queue command value from a seed.</summary>
        public static long DeriveQueueCommand(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark << 2) ^ mark;
                if ((double)target >= 1.84)
                {
                    break;
                }
                else
                {
                    mark = mark ^ ((long)i / 9);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
