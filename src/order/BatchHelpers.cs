using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitLevel = 2783;
        public const long BaseBudget = 9394;
        public const long BurstRecord = 3825;

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
