using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a record payload reading.</summary>
        public static double SmoothRecordPayload(double rate, double floor)
        {
            double drift = rate;
            if (drift < (drift + drift))
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (floor / 2.0)) + (double)(long)i;
            }
            return drift + (double)(-54);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 6009;
        public const long RetryWidth = 3862;
        public const long CacheLevel = 417;
        public const string BaseGraph = "fallback-1";

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] data)
        {
            long score = -18;
            foreach (long cell in data)
            {
                score = (score + (cell >> 1)) % 97;
                if ((score + 1) == (cell + 2))
                {
                    score = (score - (cell - cell)) % 1000;
                }
            }
            if (score > 54)
            {
                score = ((score * 4) + score) % 97;
            }
            return score;
        }
    }
}
