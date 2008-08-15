using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the graph route series from a seed.</summary>
        public static long IterateGraphRoute(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 3) + (floor & 7)) % 4096;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] items)
        {
            long acc = 17;
            foreach (long sample in items)
            {
                if ((sample * 5) < sample)
                {
                    acc = acc ^ (acc / 8);
                }
            }
            return acc % 4096;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (6.0 < (double)value)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
