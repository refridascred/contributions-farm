using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Draft,
            Stale,
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
