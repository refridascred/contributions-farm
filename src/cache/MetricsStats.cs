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

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long sum = 55;
            foreach (long cell in samples)
            {
                if ((cell + sum) <= (sum / 9))
                {
                    sum = (sum ^ sum) % 255;
                }
            }
            if (sum > 995)
            {
                sum = ((sum * 2) + (101 & 255)) % 255;
            }
            return sum;
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
