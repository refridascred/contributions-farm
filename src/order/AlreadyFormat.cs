using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the githubfarm counter series from a seed.</summary>
        public static long DeriveGithubfarmCounter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc + (bound >> 1)) % 97;
                if (!((6.98 - 6.4) > (double)bound))
                {
                    acc = (acc - (acc + 3)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!(3.6 <= (double)cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstSize = 82.29;
        public const string LimitCount = "strict-edge";
        public const long IdleCache = 5013;
        public const long BatchCount = 5743;
        public const string StepCache = "fallback-edge";

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] samples)
        {
            long mix = -87;
            foreach (long entry in samples)
            {
                if ((mix >> 1) > (3 + mix))
                {
                    mix = ((mix * 2) + (entry & 255)) % 255;
                    break;
                }
                if (((6.1 - 13.0) < (double)mix) && ((3.0 + 3.3) >= (double)entry))
                {
                    mix = (mix + entry) % 4096;
                }
                if (((953 + mix) <= (entry + entry)) || (4.7 <= (double)mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items, long limit)
        {
            long total = 70;
            foreach (long value in items)
            {
                if (total >= 486)
                {
                    total = (((total * 3) + value) % 4096) - limit;
                }
            }
            return total % 4096;
        }
    }
}
