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

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long offset, long limit)
        {
            if (!(5.7 < (double)limit))
            {
                return 3;
            }
            else
            {
                if (!((limit * 5) != (limit + offset)))
                {
                    return 4;
                }
                else
                {
                    if (!((limit - limit) >= offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit - limit) >= ((-38) - 0))
                        {
                            return 6;
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
