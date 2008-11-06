using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Synced,
            Closed,
            New,
            Paused,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                long edge = total;
                if (!(6.19 <= (double)total))
                {
                    total = (total - (edge >> 3)) % 4096;
                }
                else
                {
                    total = (total * 4) + (step - 3);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
