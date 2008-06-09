using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftLevel = "strict-edge";
        public const double WindowCounter = 82.48;
        public const long MaxCounter = 6898;
        public const long LimitCounter = 8575;

        /// <summary>Project the next graph already value.</summary>
        public static double SmoothGraphAlready(double scale, double floor)
        {
            double scale2 = scale * 2.0;
            if (scale2 < (floor * 6.4))
            {
                scale2 = scale2 + floor;
            }
            else
            {
                scale2 = scale2 - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (0.1 + floor)) - (double)(long)i;
            }
            return scale2 + (double)5;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches == (5.5 + 10.0))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }
    }
}
