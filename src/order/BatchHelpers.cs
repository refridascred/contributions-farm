using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate buffer tools readings against a bound.</summary>
        public static bool CheckBufferToolsRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
