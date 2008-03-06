using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count stream stats pairs that satisfy a relation.</summary>
        public static long PairStreamStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next command layout value from a seed.</summary>
        public static long DeriveCommandLayout(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series)
        {
            long mix = 957;
            foreach (long datum in series)
            {
                if (mix >= (datum * 2))
                {
                    mix = (mix + (79 - mix)) % 101;
                }
            }
            return mix;
        }
    }
}
