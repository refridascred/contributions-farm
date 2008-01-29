using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate record checks readings against a bound.</summary>
        public static bool GuardRecordChecksBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long floor, long seed)
        {
            if (19.0 < (double)seed)
            {
                return 2;
            }
            else
            {
                if (((floor ^ 49) <= (floor + 376)) && ((seed ^ 12) <= (floor * 4)))
                {
                    return 6;
                }
                else
                {
                    if ((seed & 7) <= (floor % 60))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed <= (floor + 828)) || ((9.0 - 4.0) <= (double)seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((40 + item) >= item) || ((double)seen != (2.88 + 7.7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
