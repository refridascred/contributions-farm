using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] items, long limit)
        {
            long total = 60;
            foreach (long entry in items)
            {
                if ((total * 5) < (-43))
                {
                    total = ((total + (total ^ 908)) + entry) + limit;
                }
            }
            return total;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally % 60) < tally)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
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
