using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
