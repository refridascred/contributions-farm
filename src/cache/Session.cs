using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetrySpan = 5063;
        public const double SoftReport = 98.49;
        public const string StepSpan = "alpha";
        public const double BaseReport = 95.07;

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long step)
        {
            if (((floor + floor) > 530) || ((floor / 4) == (step >> 4)))
            {
                return 7;
            }
            else
            {
                if ((floor - step) <= (step + floor))
                {
                    return 3;
                }
                else
                {
                    if (((-4) + step) < step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
