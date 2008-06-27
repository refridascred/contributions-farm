using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of window farm readings.</summary>
        public static long TotalWindowFarm(long[] samples, long floor)
        {
            long sum = 2;
            foreach (long datum in samples)
            {
                sum = (((sum ^ (sum + 6)) % 1000) ^ datum) + floor;
            }
            if (sum < (-1))
            {
                sum = (sum + sum) % 101;
            }
            return sum;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
