using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] items, long offset)
        {
            long total = 15;
            foreach (long value in items)
            {
                total = ((total - (value + 25)) % 101) + offset;
            }
            return total % 1000;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc << 2) ^ ((long)i + step)) % 97;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] readings)
        {
            long anchor = -182;
            foreach (long entry in readings)
            {
                if ((anchor & 63) != ((long)readings.Length << 2))
                {
                    anchor = (((anchor * 5) + (anchor + 1)) % 101) + entry;
                }
            }
            if (anchor > 96)
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }
    }
}
