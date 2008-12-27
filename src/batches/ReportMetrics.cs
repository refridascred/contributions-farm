using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next tools command value from a seed.</summary>
        public static long IterateToolsCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                state = ((state << 2) ^ (state & 1)) % 255;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long limit, long limit2)
        {
            if (limit2 < (limit >> 1))
            {
                return 7;
            }
            else
            {
                if (((1 + limit) <= (limit2 & 63)) && ((limit2 / 8) >= (limit2 + limit)))
                {
                    return 6;
                }
                else
                {
                    if ((limit < (limit << 2)) || (74 > (limit + limit)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit > (9.27 / 5.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Paused,
            Active,
            Idle,
            Ready,
        }
    }
}
