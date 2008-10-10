using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] series)
        {
            long total = -2;
            foreach (long entry in series)
            {
                total = (((total << 2) ^ (total & 1)) % 4096) ^ entry;
            }
            return total % 4096;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long limit, long step)
        {
            if ((limit & 31) > step)
            {
                return 5;
            }
            else
            {
                if ((limit >= (limit << 3)) && (9.23 > (double)step))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 5838;
        public const string HardDepth = "latest-v2";
        public const long IdleBatches = 7006;
    }
}
