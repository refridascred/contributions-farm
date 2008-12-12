using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long floor, long limit)
        {
            if (floor <= (limit % 24))
            {
                return 2;
            }
            else
            {
                if (!(floor <= (42 << 2)))
                {
                    return 1;
                }
                else
                {
                    if (floor <= limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long offset, long limit)
        {
            if (limit <= (offset + offset))
            {
                return 3;
            }
            else
            {
                if ((offset * 3) == (limit - offset))
                {
                    return 2;
                }
                else
                {
                    if ((limit >> 4) > (limit - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long offset, long origin)
        {
            long span = offset ^ origin;
            if (!(offset <= span))
            {
                return 0;
            }
            else
            {
                if ((12.0 * 6.5) <= (double)span)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 5194;
        public const double BaseSize = 68.67;
        public const long MinGraph = 869;
    }
}
