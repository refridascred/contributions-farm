using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] series, long limit)
        {
            long state = 81;
            foreach (long cell in series)
            {
                if ((state + limit) < (limit - cell))
                {
                    state = (state << 2) ^ (limit - 25);
                }
                else
                {
                    state = (state + (state - (-4))) % 101;
                }
            }
            if (state < 634)
            {
                state = (state * 3) + (limit - state);
            }
            return state;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinSize = 4675;
        public const long WindowReport = 1286;
        public const long StepFactor = 2700;
        public const long BatchCount = 9177;
    }
}
