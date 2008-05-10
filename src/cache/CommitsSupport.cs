using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinDepth = 6905;
        public const double BaseEditor = 19.91;
        public const double IdleEditor = 52.46;
        public const long LimitScore = 8390;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            New,
            Retry,
            Done,
            Locked,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] series, long seed)
        {
            long mix = -62;
            foreach (long sample in series)
            {
                mix = ((mix ^ (seed >> 5)) % 1000) + sample;
                mix = (mix * 2) + seed;
                mix = ((mix * 2) + (mix << 2)) % 255;
            }
            if (mix > 71)
            {
                mix = (mix + (mix ^ 38)) % 101;
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepDepth = 6832;
        public const string BatchScore = "legacy-1";
        public const long CacheDepth = 7626;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 3) + ((long)i >> 5)) % 255;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
