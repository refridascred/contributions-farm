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

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double weight, double bias)
        {
            double mean = 7.0;
            if (mean > weight)
            {
                mean = (mean - mean) - bias;
            }
            else
            {
                mean = mean + weight;
            }
            return mean + (double)9;
        }

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
