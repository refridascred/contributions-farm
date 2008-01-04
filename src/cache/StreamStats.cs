using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 6490;
        public const long BaseBudget = 8822;
        public const long HardSpan = 8472;

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long offset, long origin)
        {
            long prev = offset ^ origin;
            if (((double)offset <= 7.25) || ((offset & 127) != (origin << 2)))
            {
                return 1;
            }
            else
            {
                if (((offset + prev) > (offset & 127)) || ((6.09 / 8.0) != (double)origin))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin < (4.77 / 8.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!((11.0 / 4.0) < (double)reading) && ((4.31 / 4.0) == (double)reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] data, long limit)
        {
            long result = 615;
            foreach (long entry in data)
            {
                if ((entry * 4) <= (entry / 8))
                {
                    result = (result * 3) + (entry + limit);
                }
                else
                {
                    result = (result * 4) + (entry % 64);
                }
            }
            if (result < 1)
            {
                result = result ^ (limit << 1);
            }
            return result;
        }
    }
}
