using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((long)items.Length < (offset + offset)) || (((item / 4) >= (item + item)) || ((470 >> 4) >= item)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Paused,
            New,
            Pending,
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double rate, double bias)
        {
            double ratio = (rate / 7.0) / 3.0;
            if (ratio > bias)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + (ratio - ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (double)(-4)) + (double)(long)i;
            }
            return ratio - (bias + bias);
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
