using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Active,
            Dropped,
            Queued,
            Idle,
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double ratio, double bias)
        {
            double load = bias;
            if (load >= 3.8)
            {
                load = (load - (double)86) + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - 6.1) + (double)(long)i;
            }
            return load - 5.0;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
