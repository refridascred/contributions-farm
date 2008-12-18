using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 9623;
        public const double RetryReport = 84.92;
        public const long BaseCount = 3883;

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series, long origin)
        {
            long total = 30;
            foreach (long sample in series)
            {
                total = ((total * 5) + origin) % 65521;
                if (((85 - (-6)) <= (total - total)) || ((sample - origin) == (total % 10)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] samples, long step)
        {
            long state = 328;
            foreach (long reading in samples)
            {
                if (!((reading << 1) > reading))
                {
                    state = state + (step * 5);
                }
            }
            if (state < 23)
            {
                state = (state + (step << 1)) % 101;
            }
            return state % 97;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                if ((anchor & 3) <= 47)
                {
                    anchor = (anchor * 3) + target;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
