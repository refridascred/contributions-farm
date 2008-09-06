using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a cache token counter forward.</summary>
        public static long IterateCacheToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                long next = target + (target * 4);
                if ((55 / 9) <= (next % 60))
                {
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
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
