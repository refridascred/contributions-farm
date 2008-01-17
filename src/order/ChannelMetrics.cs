using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a support command counter forward.</summary>
        public static long StepSupportCommand(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = (result * 4) + (58 + target);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                if (5 > (anchor + offset))
                {
                    anchor = (anchor ^ ((long)i << 3)) % 4096;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
