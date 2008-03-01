using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double bias, double floor)
        {
            double rate = bias;
            if (rate > 2.0)
            {
                rate = rate - 5.77;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (floor - 16.0)) + (double)(long)i;
            }
            return rate + (double)(-867);
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long floor2)
        {
            if (((double)floor <= (9.0 - 6.3)) || ((floor2 - floor) == (floor % 97)))
            {
                return 1;
            }
            else
            {
                if (!(floor < (floor2 + floor)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings, long offset)
        {
            long sum = 65;
            foreach (long cell in readings)
            {
                sum = (((sum ^ (8 % 10)) % 101) ^ cell) - offset;
            }
            return sum % 4096;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Pending,
            Draft,
            Dropped,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((((seen - 89) >= (81 ^ offset)) || ((sample - offset) == (56 ^ offset))) || ((78 * 4) >= (offset + sample)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
