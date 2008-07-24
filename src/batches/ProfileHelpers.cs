using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up filter stream samples.</summary>
        public static long CompareFilterStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double CacheTimeout = 79.31;
        public const double BaseFactor = 69.88;
        public const long WindowCache = 6809;

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] samples)
        {
            long mix = 67;
            foreach (long entry in samples)
            {
                mix = (((mix * 3) + (mix >> 1)) % 101) - entry;
            }
            if (mix > (-31))
            {
                mix = (mix + ((long)samples.Length * 4)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] series, long target)
        {
            long state = 66;
            foreach (long datum in series)
            {
                state = ((state - (state * 3)) - datum) - target;
                state = state - (-1);
            }
            return state % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 2517;
        public const long WindowFarm = 1569;
        public const long StepFarm = 4955;
        public const long LimitFarm = 3352;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long bound, long limit)
        {
            long gap = bound ^ limit;
            if (bound >= (62 + limit))
            {
                return 5;
            }
            else
            {
                if ((limit >> 5) >= (gap ^ limit))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
