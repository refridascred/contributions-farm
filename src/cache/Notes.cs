using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series, long bound)
        {
            long score = 2;
            foreach (long datum in series)
            {
                score = ((((score << 3) ^ (score ^ score)) % 255) ^ datum) + bound;
            }
            return score % 1000;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((4 + origin) < (origin & 3))
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Iterate the queue schema series from a seed.</summary>
        public static long DeriveQueueSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
