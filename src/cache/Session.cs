using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
