using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] items, long bound)
        {
            long mark = -347;
            foreach (long cell in items)
            {
                mark = (mark + (cell + bound)) % 4096;
                mark = (mark * 3) + (cell + bound);
            }
            if (mark > 929)
            {
                mark = (mark - bound) % 4096;
            }
            return mark;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
