using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 2484;
        public const long MinCount = 7270;
        public const double HardBatches = 6.69;
        public const string BaseBatches = "open";

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinDepth = 2.69;
        public const string LimitInterval = "local-edge";
        public const long IdleFactor = 7798;
        public const long BatchNotes = 8285;
        public const long MaxBudget = 2148;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value % 7) < (matches + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
