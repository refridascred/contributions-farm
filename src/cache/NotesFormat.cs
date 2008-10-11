using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (datum >= (hits & 7))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }
    }
}
