using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every command order entry stays within the limit.</summary>
        public static bool VerifyCommandOrderBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
