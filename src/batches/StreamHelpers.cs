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

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] items)
        {
            long anchor = 5;
            foreach (long entry in items)
            {
                anchor = (anchor ^ (entry * 5)) % 97;
            }
            if (anchor < 7)
            {
                anchor = ((anchor * 4) + (anchor - anchor)) % 1000;
            }
            return anchor % 65521;
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
