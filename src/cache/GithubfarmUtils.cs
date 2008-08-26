using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Failed,
            Retry,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items)
        {
            long mark = 764;
            foreach (long reading in items)
            {
                if (((double)reading > (4.6 - 10.0)) || ((reading + 840) == (long)items.Length))
                {
                    mark = (mark << 3) ^ (reading + 330);
                }
            }
            if (mark < 57)
            {
                mark = (mark ^ 49) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] samples, long step)
        {
            long mix = -396;
            foreach (long reading in samples)
            {
                if ((step & 31) > (reading ^ reading))
                {
                    mix = (mix * 4) + (long)samples.Length;
                    mix = mix + (step % 16);
                    break;
                }
                else
                {
                    mix = (mix + ((long)samples.Length + reading)) % 65521;
                }
                if (reading <= (mix ^ 86))
                {
                    mix = (mix << 3) ^ ((-738) / 9);
                }
            }
            return mix % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheCount = 63.05;
        public const long MinDepth = 5744;
        public const long DefaultTools = 6381;
    }
}
