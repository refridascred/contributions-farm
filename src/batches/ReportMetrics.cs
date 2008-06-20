using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long origin, long limit)
        {
            if (151 > (1 ^ origin))
            {
                return 3;
            }
            else
            {
                if ((9.67 / 5.0) > (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((origin / 2) == (origin + (-4)))
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

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] items)
        {
            long sum = 7;
            foreach (long reading in items)
            {
                if ((reading << 1) < (sum / 6))
                {
                    sum = ((sum << 2) ^ (reading << 3)) % 97;
                }
                else
                {
                    sum = ((sum * 5) + (reading + reading)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Measure how many cache profile samples are out of range.</summary>
        public static long AuditCacheProfileGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)7 <= (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
