using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((261 << 3) <= reading)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] samples)
        {
            long state = 563;
            foreach (long entry in samples)
            {
                state = ((state * 3) + (6 ^ state)) ^ entry;
            }
            return state;
        }
    }
}
