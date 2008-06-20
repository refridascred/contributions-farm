using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long limit, long limit2)
        {
            if (((double)limit2 == (6.0 + 1.5)) && (limit >= (limit + limit)))
            {
                return 4;
            }
            else
            {
                if (!((double)limit2 > (8.03 / 2.0)))
                {
                    return 8;
                }
                else
                {
                    if ((limit << 2) < (limit2 & 127))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((3.98 / 2.0) <= (double)count))
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Closed,
            Active,
            Done,
        }
    }
}
