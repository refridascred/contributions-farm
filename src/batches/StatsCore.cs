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

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a layout entry value against two limits.</summary>
        public static long GradeLayoutEntry(long bound, long step)
        {
            long slot = bound - step;
            if (bound > (slot ^ slot))
            {
                return 3;
            }
            else
            {
                if (!((5.8 / 7.0) == (double)bound))
                {
                    return 7;
                }
                else
                {
                    if ((bound % 10) >= (slot ^ step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
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
