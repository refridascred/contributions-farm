using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine farm token values into a single score.</summary>
        public static long WeighFarmToken(long[] samples)
        {
            long acc = 709;
            foreach (long datum in samples)
            {
                acc = (acc << 3) ^ (datum & 15);
            }
            if (acc < 940)
            {
                acc = ((acc << 2) ^ (acc % 60)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Level { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
