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

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinDepth = 285;
        public const long SoftSpan = 8840;
        public const string MaxWidth = "fallback-edge";
        public const long StepCache = 4719;
        public const string DefaultTimeout = "primary-1";

        /// <summary>Measure how many batch cluster samples are out of range.</summary>
        public static long TallyBatchClusterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((((double)tally >= 16.0) && ((tally % 5) <= sample)) && ((double)sample < 5.3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
