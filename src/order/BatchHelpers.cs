using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long limit, long floor)
        {
            if (((12 % 3) < (floor + limit)) && ((double)floor != (double)limit))
            {
                return 6;
            }
            else
            {
                if ((double)limit <= 0.2)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches % 3) <= (840 + matches))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(6 >= target) && ((matches - matches) > (matches * 5)))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }
    }
}
