using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i >= (anchor + (long)i)) && ((8.1 / 3.0) <= (double)limit))
                {
                    anchor = anchor - (limit >> 4);
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor * 3) + ((long)i >> 4)) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] levels, long origin)
        {
            long anchor = 9;
            foreach (long datum in levels)
            {
                if ((datum << 1) == (origin * 3))
                {
                    anchor = (anchor - (2 * 5)) % 255;
                }
                else
                {
                    anchor = anchor ^ (datum % 2);
                }
            }
            if (anchor < 5)
            {
                anchor = anchor - ((-83) << 1);
            }
            return anchor;
        }
    }
}
