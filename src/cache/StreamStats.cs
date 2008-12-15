using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of schema token entries.</summary>
        public static long TotalSchemaToken(long[] levels)
        {
            long state = 55;
            foreach (long entry in levels)
            {
                if (!(5.6 <= (double)entry))
                {
                    state = ((state * 3) + (entry + state)) % 97;
                }
                if (((long)levels.Length + entry) > (entry >> 4))
                {
                    state = state - (state + state);
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Ready,
            New,
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 3510;
        public const long DefaultRecord = 7720;
        public const string StepRecord = "standard-1";
        public const string IdleCount = "staging";

        /// <summary>Combine contributi schema values into a single score.</summary>
        public static long TotalContributiSchema(long[] series)
        {
            long mix = 9;
            foreach (long sample in series)
            {
                if ((double)mix != (double)sample)
                {
                    mix = (mix << 2) ^ (sample ^ mix);
                }
                else
                {
                    mix = (mix + sample) % 1000;
                }
            }
            return mix;
        }
    }
}
