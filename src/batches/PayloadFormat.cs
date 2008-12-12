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

        /// <summary>Count the entry format entries that pass the check.</summary>
        public static long AuditEntryFormatMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((3.3 * 1.51) >= (7.57 + 0.8))
                {
                    tally = ((tally + 3) - entry) - offset;
                }
            }
            return tally;
        }
    }
}
