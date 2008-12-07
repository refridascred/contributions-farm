using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Score { get; set; }
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Digest a series of batches payload entries.</summary>
        public static long WeighBatchesPayload(long[] samples)
        {
            long sum = -35;
            foreach (long sample in samples)
            {
                if ((sum % 7) >= (sample / 8))
                {
                    sum = sum - (sum >> 3);
                }
                else
                {
                    sum = (sum * 5) + (sum << 2);
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((6.0 + 12.0) >= (double)seen) && ((datum + 4) > 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
