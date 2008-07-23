using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next farm batch value.</summary>
        public static double AdjustFarmBatch(double rate, double floor)
        {
            double rate2 = 2.2 / 4.0;
            return (rate2 + floor) + rate;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Score { get; set; }
            public bool Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
