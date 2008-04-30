using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Pending,
            Done,
            Dropped,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry * 4) != (seen % 2))
                {
                    seen = (seen + 3) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long limit, long origin)
        {
            if ((origin >> 1) > (379 + origin))
            {
                return 8;
            }
            else
            {
                if ((double)origin > (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((3.19 / 4.0) >= (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(6.54 >= (double)limit))
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
        }
    }
}
