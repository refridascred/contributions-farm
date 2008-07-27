using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Audit already support readings against a rule.</summary>
        public static long MeasureAlreadySupportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (entry > (matches - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Dropped,
            Idle,
            Queued,
            Retry,
        }
    }
}
