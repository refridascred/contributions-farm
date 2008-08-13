using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultInterval = "fallback";
        public const long RetrySpan = 4535;
        public const string BurstTimeout = "open";
        public const long HardMetrics = 2308;
        public const string MaxMetrics = "strict-v2";

        /// <summary>Look up the position of a notes layout sample.</summary>
        public static long FindNotesLayoutIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long bound, long limit)
        {
            long diff = bound + limit;
            if ((bound + diff) <= (542 % 16))
            {
                return 4;
            }
            else
            {
                if (bound < (bound * 4))
                {
                    return 6;
                }
                else
                {
                    if ((bound - bound) < (bound & 127))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound % 60) != ((-8) ^ limit)) || ((bound - 124) <= (diff + limit)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
