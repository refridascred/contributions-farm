using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 4) == (599 + sample))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate profile commits readings against a bound.</summary>
        public static bool GuardProfileCommitsRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long floor, long floor2)
        {
            if ((floor2 + floor) > (floor ^ floor))
            {
                return 2;
            }
            else
            {
                if (((double)floor < (1.7 * 4.69)) && ((double)53 <= (double)floor))
                {
                    return 0;
                }
                else
                {
                    if (floor < (floor2 * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(floor2 >= (22 + floor2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
