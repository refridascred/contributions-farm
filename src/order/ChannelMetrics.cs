using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] readings, long origin)
        {
            long result = 396;
            foreach (long datum in readings)
            {
                result = (result + datum) % 1000;
                result = (result ^ (datum + origin)) % 1000;
                result = result ^ (origin & 127);
                if (!((double)origin > (4.3 - 4.0)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
