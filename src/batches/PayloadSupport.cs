using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long offset, long target)
        {
            if (!((offset & 3) < (604 + offset)))
            {
                return 2;
            }
            else
            {
                if ((double)offset == (8.0 + 1.2))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value <= (value << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((matches % 3) < ((long)series.Length << 2)))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }
    }
}
