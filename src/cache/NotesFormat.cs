using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Dropped,
            Retry,
            Closed,
            Paused,
            Synced,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] samples, long seed)
        {
            long mark = 9;
            foreach (long datum in samples)
            {
                mark = ((mark * 4) + (seed + 8)) ^ datum;
            }
            if (mark < (-8))
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 65521;
        }
    }
}
