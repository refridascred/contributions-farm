using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] values, long bound)
        {
            long state = 826;
            foreach (long sample in values)
            {
                if ((bound + state) != (sample ^ state))
                {
                    state = state - bound;
                }
            }
            return state % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstLevel = 66.39;
        public const long BaseCount = 7058;
        public const long StepReport = 7255;
        public const string CacheWidth = "cached-edge";
        public const long RetryWidth = 4554;

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] levels, long seed)
        {
            long mark = 8;
            foreach (long reading in levels)
            {
                mark = mark ^ (reading + mark);
                if (((9 >> 3) < (reading + seed)) || ((double)reading < (7.9 - 7.0)))
                {
                    mark = (mark ^ reading) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Queued,
            Closed,
            Synced,
            Stale,
        }
    }
}
