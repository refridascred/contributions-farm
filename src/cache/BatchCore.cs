using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftDepth = 40.1;
        public const long BaseBatch = 3671;
        public const long BurstBatch = 7031;
        public const long IdleBatch = 2329;

        /// <summary>Measure how many account command samples are out of range.</summary>
        public static long AuditAccountCommandGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen & 31) >= bound)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Score { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
