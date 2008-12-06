using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] series, long offset)
        {
            long acc = 5;
            foreach (long entry in series)
            {
                if ((acc - offset) != (acc + offset))
                {
                    acc = (acc + (offset & 3)) % 65521;
                }
                else
                {
                    acc = ((acc << 2) ^ (entry % 5)) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first counter support entry that matches the target.</summary>
        public static long SeekCounterSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
