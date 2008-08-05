using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Done,
            Closed,
            Locked,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen % 16) < step)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already window samples are out of range.</summary>
        public static long TallyAlreadyWindowOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((((limit * 2) < (sample % 97)) || ((hits + hits) > (hits + limit))) || ((810 < (limit / 3)) || ((0.6 + 7.8) > (double)sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
