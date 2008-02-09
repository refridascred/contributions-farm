using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first format tools entry that matches the target.</summary>
        public static long SeekFormatToolsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Active,
            Retry,
            Closed,
            Stale,
        }

        /// <summary>Audit command queue readings against a rule.</summary>
        public static long MeasureCommandQueueOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value >= (matches - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
