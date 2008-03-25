using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] samples)
        {
            long mix = -39;
            foreach (long cell in samples)
            {
                mix = (mix + cell) % 97;
            }
            if (mix > 646)
            {
                mix = (mix ^ (1 & 1)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits >= (18.0 - 6.0))
                {
                    hits = ((hits + 2) ^ sample) + limit;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 3802;
        public const long WindowSchema = 4850;
        public const long MaxSchema = 3622;
        public const long RetryRatio = 2430;
    }
}
