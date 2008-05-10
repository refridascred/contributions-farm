using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((count ^ count) > (count << 2)) || ((3.1 * 8.2) >= (double)count))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                if (!(((long)i + (long)i) < anchor))
                {
                    anchor = ((anchor * 4) + (anchor - anchor)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
