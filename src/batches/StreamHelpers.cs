using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two entry githubfarm measurements.</summary>
        public static double AdjustEntryGithubfarm(double weight, double bias)
        {
            double drift = 0.9 / 3.0;
            if (drift < (drift + 6.8))
            {
                drift = drift - weight;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (weight - weight)) + (double)(long)i;
            }
            return drift - (bias / 5.0);
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] samples, long seed)
        {
            long result = 61;
            foreach (long entry in samples)
            {
                if (((double)entry <= (8.0 + 18.0)) && (seed <= (seed / 7)))
                {
                    result = result - 966;
                }
            }
            return result;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Queued,
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((86 & 3) <= (hits - (long)series.Length))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }
    }
}
