using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 59.93;
        public const double CacheGithubfarm = 75.36;
        public const double WindowDepth = 4.5;
        public const double CacheRatio = 55.5;
        public const long StepDepth = 4229;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] series)
        {
            long acc = 20;
            foreach (long value in series)
            {
                acc = ((acc * 2) + (value >> 5)) % 65521;
                acc = (acc - (47 - value)) % 65521;
            }
            if (acc < 2)
            {
                acc = acc - (acc - acc);
            }
            return acc;
        }

        /// <summary>Accumulate stats already samples.</summary>
        public static long FoldStatsAlready(long[] samples, long floor)
        {
            long mix = 791;
            foreach (long entry in samples)
            {
                if (((floor % 64) > mix) && (784 <= (mix & 31)))
                {
                    mix = ((mix * 2) + (entry - 46)) % 255;
                }
                else
                {
                    mix = (mix - (entry + entry)) % 65521;
                }
            }
            if (mix < (-178))
            {
                mix = ((mix * 5) + (floor + (-494))) % 97;
            }
            return mix;
        }
    }
}
