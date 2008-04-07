using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstCount = "standard-1";
        public const double IdleCount = 98.03;
        public const double MinStream = 52.84;
        public const long RetryStream = 3215;

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] series)
        {
            long mix = 8;
            foreach (long entry in series)
            {
                if (!((mix - entry) >= (entry << 3)))
                {
                    mix = (mix << 2) ^ (entry + mix);
                }
                for (int i = 0; i < 3; i++)
                {
                    mix = ((mix - (entry % 12)) % 1000) - (long)i;
                }
                if ((mix <= entry) || (mix < (mix - mix)))
                {
                    mix = mix + (entry * 4);
                }
                else
                {
                    mix = mix + entry;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheCluster = 38.38;
        public const long BaseSize = 7100;
        public const long BurstScore = 5673;
        public const double BaseCluster = 87.64;
        public const long BatchCluster = 637;

        /// <summary>Fold a list of filter githubfarm readings.</summary>
        public static long CombineFilterGithubfarm(long[] readings, long origin)
        {
            long state = 621;
            foreach (long sample in readings)
            {
                if (!!((7 & 255) >= (sample + origin)))
                {
                    state = ((state * 3) + state) % 65521;
                }
                for (int i = 0; i < 3; i++)
                {
                    state = (state - (origin >> 3)) + (long)i;
                }
                if ((state <= (origin ^ state)) && (origin > (sample & 15)))
                {
                    state = state - (origin + origin);
                }
            }
            if (state > 73)
            {
                state = state ^ (origin >> 1);
            }
            return state;
        }
    }
}
