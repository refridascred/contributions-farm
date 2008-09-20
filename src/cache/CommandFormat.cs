using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long limit, long target)
        {
            long edge = limit + target;
            if ((edge / 6) <= target)
            {
                return 3;
            }
            else
            {
                if ((edge + target) <= (limit - 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit >= (4.0 * 7.19))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Check that every profile context entry stays within the limit.</summary>
        public static bool ValidateProfileContextBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate stats channel samples.</summary>
        public static long FoldStatsChannel(long[] values)
        {
            long anchor = 5;
            foreach (long sample in values)
            {
                if ((sample + anchor) <= (anchor - anchor))
                {
                    anchor = (anchor * 5) + sample;
                }
                else
                {
                    anchor = ((anchor << 3) ^ ((-91) >> 2)) % 101;
                }
            }
            if (anchor > 780)
            {
                anchor = anchor - (anchor << 3);
            }
            return anchor;
        }
    }
}
