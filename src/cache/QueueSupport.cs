using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a metrics commits value against two limits.</summary>
        public static long ClassifyMetricsCommits(long offset, long floor)
        {
            long offset2 = offset + floor;
            if ((97 % 2) <= (63 - offset2))
            {
                return 7;
            }
            else
            {
                if ((offset ^ 5) != (22 - offset2))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset != (9.82 - 5.0)) && (floor >= offset2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset << 1) != (offset2 / 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            Idle,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long floor, long floor2)
        {
            if ((((-9) << 3) >= (floor2 + floor2)) || (floor >= floor2))
            {
                return 0;
            }
            else
            {
                if (floor2 <= floor)
                {
                    return 3;
                }
                else
                {
                    if ((0 + floor2) < floor2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
