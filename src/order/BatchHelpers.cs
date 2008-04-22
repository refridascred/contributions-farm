using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] samples)
        {
            long sum = 9;
            foreach (long value in samples)
            {
                sum = sum ^ sum;
                if ((sum & 127) <= (sum - value))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long origin, long floor)
        {
            long edge = origin - floor;
            if ((((-374) % 2) < (edge / 3)) || ((double)origin < (double)(-43)))
            {
                return 6;
            }
            else
            {
                if ((6.7 * 9.13) < (double)edge)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
