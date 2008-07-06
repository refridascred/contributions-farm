using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultCount = "stable";
        public const double BurstBuffer = 82.55;
        public const long CacheBuffer = 3160;
        public const long IdleBuffer = 6474;
        public const double MaxScore = 1.14;

        /// <summary>Classify a batches token pair into a bucket.</summary>
        public static long SortBatchesToken(long seed, long offset)
        {
            if ((52 ^ seed) > (94 << 3))
            {
                return 5;
            }
            else
            {
                if ((seed << 1) < seed)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] readings, long target)
        {
            long mix = -8;
            foreach (long sample in readings)
            {
                if ((target + sample) >= 0)
                {
                    mix = (mix << 3) ^ (sample ^ target);
                }
                else
                {
                    mix = ((mix << 3) ^ (target ^ (long)readings.Length)) % 255;
                }
            }
            if (mix > 153)
            {
                mix = (mix + target) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] values, long seed)
        {
            long anchor = -618;
            foreach (long cell in values)
            {
                anchor = (anchor + (seed + anchor)) % 97;
                if ((anchor - cell) < anchor)
                {
                    anchor = (anchor + (anchor % 24)) % 1000;
                }
            }
            return anchor;
        }
    }
}
