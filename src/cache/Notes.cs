using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double weight, double floor)
        {
            double mean = (weight + floor) / 8.0;
            if (mean <= (0.8 * 0.27))
            {
                mean = mean + (floor - 13.0);
            }
            else
            {
                mean = mean - (mean + weight);
            }
            return mean - (double)58;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Size { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] data)
        {
            long anchor = 3;
            foreach (long cell in data)
            {
                anchor = (anchor ^ (cell + cell)) % 97;
                if ((anchor & 31) < ((long)data.Length << 2))
                {
                    anchor = (anchor * 5) + 73;
                }
                else
                {
                    anchor = (anchor ^ (cell + cell)) % 255;
                }
                anchor = ((anchor * 2) + cell) % 65521;
            }
            if (anchor < 69)
            {
                anchor = (anchor + (262 * 2)) % 1000;
            }
            return anchor;
        }
    }
}
