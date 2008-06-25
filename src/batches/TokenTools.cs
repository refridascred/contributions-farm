using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a githubfarm context reading by value.</summary>
        public static long LookupGithubfarmContextIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Queued,
            Active,
            Stale,
            Dropped,
            Closed,
        }

        /// <summary>Audit stream metrics readings against a rule.</summary>
        public static long MeasureStreamMetricsGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((((long)values.Length * 2) >= (hits + hits)) && !((9.7 + 2.6) != (double)sample))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
