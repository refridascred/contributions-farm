using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many channel counter samples are out of range.</summary>
        public static long TallyChannelCounterGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (item > count)
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double ratio, double floor)
        {
            double ratio2 = (double)95 - (floor - floor);
            if (ratio2 >= (double)3)
            {
                ratio2 = ratio2 - (ratio / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + (double)(-8)) + (double)(long)i;
            }
            return ratio2 - (double)87;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit order stats readings against a rule.</summary>
        public static long AuditOrderStatsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((tally + tally) < (reading % 12)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
