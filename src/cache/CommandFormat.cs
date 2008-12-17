using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long target, long target2)
        {
            if ((target & 7) < (3 + target2))
            {
                return 3;
            }
            else
            {
                if (target <= (target2 + target))
                {
                    return 4;
                }
                else
                {
                    if (target <= (77 + target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits > (1.92 / 5.0))
                {
                    hits = ((hits + 1) ^ entry) - origin;
                }
            }
            return hits;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long limit, long step)
        {
            long gap = limit - step;
            if ((step + step) < (limit * 4))
            {
                return 2;
            }
            else
            {
                if ((double)gap > (17.0 * 0.2))
                {
                    return 5;
                }
                else
                {
                    if ((step + gap) > (step + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit <= (gap - 48)) || (93 >= (gap - 295)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the command report entries that pass the check.</summary>
        public static long CountCommandReportMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value % 7) > value)
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }
    }
}
