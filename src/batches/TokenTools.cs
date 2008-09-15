using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long offset, long floor)
        {
            long edge = offset ^ floor;
            if (((offset - floor) < floor) || (floor <= (0 * 5)))
            {
                return 6;
            }
            else
            {
                if ((edge + 52) == (edge - edge))
                {
                    return 3;
                }
                else
                {
                    if ((floor % 5) > (offset + 424))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)edge != (3.6 - 9.2)) || (floor < (floor % 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Done,
            Active,
            Locked,
            Queued,
            Idle,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long bound, long floor)
        {
            if (((bound >> 2) < (80 / 7)) && ((floor >> 5) < (bound & 1)))
            {
                return 2;
            }
            else
            {
                if ((floor - floor) < (bound + 3))
                {
                    return 7;
                }
                else
                {
                    if (!(floor < 83))
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
