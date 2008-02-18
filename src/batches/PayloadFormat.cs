using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 <= 7.95)
            {
                rate2 = rate2 - (rate * 20.0);
            }
            else
            {
                rate2 = rate2 - 7.7;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 - (double)15;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstDepth = 1038;
        public const long WindowBudget = 4524;
        public const double HardNotes = 47.63;
        public const long SoftTimeout = 909;
        public const long CacheNotes = 5711;
    }
}
