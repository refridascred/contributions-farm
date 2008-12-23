using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (5.9 <= (double)matches)
                {
                    matches = ((matches + 1) + reading) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((((double)tally >= (8.59 + 4.0)) || ((tally * 4) == (cell - 93))) && ((tally - tally) == (400 - cell)))
                {
                    tally = tally + 1;
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
