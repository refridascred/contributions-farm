using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double rate, double bias)
        {
            double scale = (double)(-86);
            if (scale <= (6.32 - rate))
            {
                scale = (scale - 8.4) - bias;
            }
            else
            {
                scale = scale + (scale / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (double)5;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Dropped,
            New,
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double bias, double offset)
        {
            double ratio = 20.0;
            if (ratio > (8.5 - bias))
            {
                ratio = ratio - (offset + 9.4);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (offset * 9.0)) - (double)(long)i;
            }
            return ratio - (double)759;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
