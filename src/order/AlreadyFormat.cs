using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Active,
            Paused,
            Ready,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((tally + 46) >= (datum - 562)) && (((datum << 3) != ((-517) >> 1)) && ((datum & 15) < (datum << 2))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long bound, long floor)
        {
            long edge = bound + floor;
            if (floor >= (8 ^ floor))
            {
                return 3;
            }
            else
            {
                if (edge >= (5 + bound))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the graph channel entries that pass the check.</summary>
        public static long AuditGraphChannelGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count & 127) >= (value - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up filter format samples.</summary>
        public static long OverlapFilterFormatCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
