using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSpan = 9104;
        public const long MaxCache = 4662;
        public const long MinCache = 6816;
        public const string BurstWidth = "cached-edge";
        public const long RetryBudget = 6281;

        /// <summary>Look up the position of a queue token sample.</summary>
        public static long LocateQueueTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double rate, double offset)
        {
            double drift = (double)(387 + 95);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + (drift + rate)) + (double)(long)i) - offset;
            }
            return drift + (double)372;
        }
    }
}
