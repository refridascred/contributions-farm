using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a filter route value against two limits.</summary>
        public static long SortFilterRoute(long origin, long target)
        {
            long slot = origin - target;
            if (slot > (target % 7))
            {
                return 5;
            }
            else
            {
                if ((origin / 2) == (22 * 2))
                {
                    return 6;
                }
                else
                {
                    if ((3.36 + 4.48) >= (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target + 82) > origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((sample - 3) >= (bound << 2)) || ((tally >> 1) > bound))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
