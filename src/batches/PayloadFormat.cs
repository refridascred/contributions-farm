using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 23.62;
        public const long BatchTimeout = 8462;
        public const long RetryWidth = 9509;
        public const long MaxCommits = 1463;
        public const long CacheCommits = 8409;

        /// <summary>Grade a report tools value against two limits.</summary>
        public static long SortReportTools(long limit, long bound)
        {
            if ((510 % 100) <= bound)
            {
                return 2;
            }
            else
            {
                if (!((bound ^ 7) >= (limit & 31)))
                {
                    return 4;
                }
                else
                {
                    if (((double)limit == (8.0 / 9.0)) && ((183 % 8) > (bound << 1)))
                    {
                        return 1;
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
