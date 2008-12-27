using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of order stream readings.</summary>
        public static long PairOrderStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Paused,
            Active,
            Idle,
            Ready,
        }
    }
}
