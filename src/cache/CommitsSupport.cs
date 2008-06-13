using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample >> 4) <= (sample - matches))
                {
                    matches = (matches + 1) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a farm githubfarm reading.</summary>
        public static double AdjustFarmGithubfarm(double rate, double floor)
        {
            double rate2 = rate;
            return (rate2 + (double)372) + floor;
        }

        /// <summary>Match up tools token samples.</summary>
        public static long MatchToolsTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Stale,
            Dropped,
            Paused,
            Queued,
            Pending,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleScore = "strict-edge";
        public const double RetryCount = 2.29;
        public const long SoftCount = 1904;
        public const long CacheFactor = 656;
        public const long BaseWidth = 2082;
    }
}
