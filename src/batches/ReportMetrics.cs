using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitSpan = 9057;
        public const long DefaultBudget = 2242;
        public const long LimitSize = 5663;
        public const long RetryRatio = 4610;
        public const long BatchSpan = 7175;

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseTimeout = 1788;
        public const long MinWidth = 5798;
        public const long StepSpan = 5887;
    }
}
