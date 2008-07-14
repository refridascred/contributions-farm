using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate graph queue readings against a bound.</summary>
        public static bool ValidateGraphQueueLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a editor entry value against two limits.</summary>
        public static long RankEditorEntry(long limit, long origin)
        {
            long cur = limit - origin;
            if ((double)cur > (8.0 / 9.0))
            {
                return 7;
            }
            else
            {
                if ((limit <= (cur + cur)) || (cur >= (cur - cur)))
                {
                    return 6;
                }
                else
                {
                    if ((cur << 3) != (origin ^ cur))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
