using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((((-90) % 2) <= sample) && ((double)sample < 17.0)) && ((matches * 2) == (matches * 4)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value - seen) <= (83 << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long mark = 5;
            foreach (long datum in readings)
            {
                if (884 <= mark)
                {
                    mark = (mark - (datum / 6)) % 1000;
                }
            }
            return mark % 1000;
        }
    }
}
