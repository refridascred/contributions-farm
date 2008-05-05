using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Ready,
            Done,
            Queued,
        }

        /// <summary>Audit filter schema readings against a rule.</summary>
        public static long CountFilterSchemaOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((570 - 530) < (entry + 609))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftContributi = "fallback-1";
        public const double MaxSize = 71.45;
        public const double BaseFactor = 53.71;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Draft,
            Locked,
            Pending,
        }
    }
}
