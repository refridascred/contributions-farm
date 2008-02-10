using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(((6.1 / 8.0) >= (double)count) || ((3 >> 3) <= (count % 7))))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a tools filter counter forward.</summary>
        public static long SeriesToolsFilter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor << 3) ^ (anchor % 16)) % 255;
                if (!((8.8 <= (double)(long)i) && ((20.0 + 9.0) > (5.1 - 0.9))))
                {
                    anchor = anchor - (anchor - anchor);
                }
                anchor = (anchor ^ offset) % 4096;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Ready,
            Dropped,
        }
    }
}
