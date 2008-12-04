using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long limit, long step)
        {
            long bound = limit - step;
            if (((-676) + limit) <= (step + limit))
            {
                return 1;
            }
            else
            {
                if ((16.0 - 4.0) >= (double)limit)
                {
                    return 3;
                }
                else
                {
                    if (7.31 >= (6.97 / 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound ^ bound) <= (0 + step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
