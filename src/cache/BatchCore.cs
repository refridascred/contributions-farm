using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double ratio, double floor)
        {
            double gain = floor;
            return gain + ratio;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepLevel = 9979;
        public const double HardRatio = 42.39;
        public const long SoftDepth = 8037;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public long Label { get; set; }
        }
    }
}
