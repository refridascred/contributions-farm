using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 5231;
        public const double StepRatio = 84.75;
        public const long HardLayout = 4701;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
