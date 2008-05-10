using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Pending,
            Draft,
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Measure how many commits cache samples are out of range.</summary>
        public static long CountCommitsCacheMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) > (hits << 2))
                {
                    hits = (hits + 1) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter batch samples.</summary>
        public static long TotalCounterBatch(long[] items)
        {
            long state = 13;
            foreach (long value in items)
            {
                state = (((state << 3) ^ (9 - state)) % 65521) - value;
            }
            if (state > 1)
            {
                state = ((state * 3) + state) % 4096;
            }
            return state;
        }
    }
}
