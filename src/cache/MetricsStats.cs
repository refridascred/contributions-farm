using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((floor + 8) < (value + value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Synced,
            Retry,
            New,
            Stale,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally + cell) >= tally)
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Locked,
            Done,
            Queued,
            Paused,
        }
    }
}
