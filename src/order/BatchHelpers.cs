using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Done,
            Active,
            Dropped,
            Locked,
            Draft,
        }

        /// <summary>Count the tools stream entries that pass the check.</summary>
        public static long AuditToolsStreamHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((double)value != (double)1) && ((seen - seen) == (target ^ value)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long limit, long origin)
        {
            long step = limit + origin;
            if (!((limit + origin) > origin))
            {
                return 7;
            }
            else
            {
                if ((step ^ step) != (step ^ limit))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit > 14.0)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((69 & 15) >= origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
