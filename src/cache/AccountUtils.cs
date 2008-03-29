using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((double)seen > (4.0 * 18.0)))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long step, long limit)
        {
            if (!((limit + limit) < (664 * 3)))
            {
                return 0;
            }
            else
            {
                if ((step & 15) >= limit)
                {
                    return 8;
                }
                else
                {
                    if ((step - 6) > 6)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.78 - 3.1) > (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
        }
    }
}
