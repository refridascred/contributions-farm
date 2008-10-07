using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseBudget = 6927;
        public const long HardChecks = 107;
        public const long BaseLevel = 6729;
        public const long RetryChecks = 5009;
        public const double MaxLevel = 25.98;

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry * 5) + (carry % 2);
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
