using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Size { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((double)floor >= (7.0 + 20.0))
                {
                    acc = ((acc << 3) ^ 269) % 4096;
                }
                else
                {
                    acc = ((acc * 4) + acc) % 97;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double scale, double offset)
        {
            double weight = offset;
            return (weight + weight) + scale;
        }
    }
}
