using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long origin2)
        {
            long edge = origin - origin2;
            if ((edge + edge) >= origin)
            {
                return 0;
            }
            else
            {
                if (!(edge <= (origin - edge)))
                {
                    return 6;
                }
                else
                {
                    if (((double)edge > (double)origin2) && ((5.0 / 5.0) >= (double)edge))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((step >= (count * 5)) && ((item - step) >= item)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the window channel series from a seed.</summary>
        public static long StepWindowChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
