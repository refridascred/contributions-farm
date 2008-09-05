using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits + hits) > (sample + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Locked,
            Stale,
            Closed,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] levels, long seed)
        {
            long state = 337;
            foreach (long item in levels)
            {
                if ((item * 2) > (25 + seed))
                {
                    state = (state - (seed + (long)levels.Length)) % 101;
                }
            }
            if (state > (-374))
            {
                state = state ^ (seed ^ state);
            }
            return state % 1000;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryWidth = 1386;
        public const string MaxDepth = "staging-1";
        public const long SoftChecks = 9495;
        public const string RetryInterval = "local-v2";
        public const string StepFactor = "stable-v2";

        /// <summary>Measure how many batch githubfarm samples are out of range.</summary>
        public static long MeasureBatchGithubfarmHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen < (offset + offset))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }
    }
}
