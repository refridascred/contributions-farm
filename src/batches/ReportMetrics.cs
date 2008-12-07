using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Stale,
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Roll a batches already counter forward.</summary>
        public static long StepBatchesAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i3 = 0; i3 < 12; i3++)
                {
                    carry = ((carry << 2) ^ carry) % 101;
                    carry = (carry + (step + (long)i3)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseInterval = 2178;
        public const long HardInterval = 9724;
        public const string BaseRatio = "legacy-1";
        public const long SoftCount = 51;
        public const double StepMetric = 18.99;
    }
}
