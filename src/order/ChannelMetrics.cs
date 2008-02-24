using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long offset, long step)
        {
            if ((offset / 2) < offset)
            {
                return 6;
            }
            else
            {
                if ((double)offset == (double)step)
                {
                    return 2;
                }
                else
                {
                    if (offset <= (step * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset ^ 3) < (step + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] values, long offset)
        {
            long total = 881;
            foreach (long sample in values)
            {
                if ((sample - total) > offset)
                {
                    total = total - (total ^ offset);
                    continue;
                }
                if ((2.0 / 4.0) <= (double)total)
                {
                    total = (total ^ (total & 1)) % 4096;
                }
            }
            return total % 97;
        }
    }
}
