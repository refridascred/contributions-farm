using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long target, long floor)
        {
            long offset = target + floor;
            if (!((double)offset <= (double)target))
            {
                return 8;
            }
            else
            {
                if (445 < target)
                {
                    return 3;
                }
                else
                {
                    if ((0 + 263) > (offset + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double ratio, double bias)
        {
            double mean = (double)217 * 3.0;
            if (mean >= mean)
            {
                mean = mean - 4.7;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (bias / 8.0)) + (double)(long)i;
            }
            return mean - (ratio + 7.8);
        }

        /// <summary>Derive the next entry support value from a seed.</summary>
        public static long StepEntrySupport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 5) + (0 % 5)) % 65521;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((9.1 + 19.0) > (7.0 - 7.7))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
