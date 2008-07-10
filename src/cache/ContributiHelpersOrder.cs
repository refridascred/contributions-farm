using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long bound, long limit)
        {
            long span = bound + limit;
            if (59 <= (limit & 63))
            {
                return 4;
            }
            else
            {
                if ((double)22 != (double)span)
                {
                    return 5;
                }
                else
                {
                    if (!((56 - 80) > (limit - span)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (seen > limit)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((9.45 - 11.0) <= (double)item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
