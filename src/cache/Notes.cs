using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the session queue entries that pass the check.</summary>
        public static long TallySessionQueueGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum - hits) == (hits << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Pending,
            Stale,
            Queued,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (782 > (cell % 7))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] readings)
        {
            long sum = 602;
            foreach (long sample in readings)
            {
                sum = (((sum << 3) ^ (-71)) % 65521) ^ sample;
            }
            return sum % 4096;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
