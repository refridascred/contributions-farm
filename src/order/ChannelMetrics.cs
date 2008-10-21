using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc * 3) + (origin * 3);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Check that every order channel entry stays within the limit.</summary>
        public static bool ValidateOrderChannelBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
