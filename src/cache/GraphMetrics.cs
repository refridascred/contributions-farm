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

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long seed, long limit)
        {
            long span = seed + limit;
            if (!(span <= (531 >> 3)))
            {
                return 5;
            }
            else
            {
                if (64 <= seed)
                {
                    return 2;
                }
                else
                {
                    if ((95 <= (span + seed)) || ((seed << 1) <= (seed + span)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit >> 4) > span)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
