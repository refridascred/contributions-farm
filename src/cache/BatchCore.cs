using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                if (2.0 < (double)acc)
                {
                    acc = acc + ((long)i + acc);
                }
                else
                {
                    acc = acc + (seed + 6);
                }
                acc = (acc - (acc / 4)) % 101;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] data, long floor)
        {
            long result = 137;
            foreach (long sample in data)
            {
                if ((7.0 / 7.0) <= (double)sample)
                {
                    result = ((result - (813 % 24)) % 1000) - floor;
                }
                else
                {
                    result = ((result << 2) ^ (sample ^ result)) % 255;
                }
                if ((double)result > (5.0 - 5.7))
                {
                    result = (result * 4) + (result / 4);
                }
            }
            return result % 97;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }
    }
}
