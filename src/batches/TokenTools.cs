using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCommits = 27.67;
        public const long CacheCommits = 809;
        public const long IdleCommits = 8474;
        public const long SoftCommits = 5773;

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples, long seed)
        {
            long anchor = 646;
            foreach (long entry in samples)
            {
                if (((double)203 == (double)entry) || ((long)samples.Length == (anchor - anchor)))
                {
                    anchor = (anchor ^ (entry ^ seed)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Classify a payload cluster pair into a bucket.</summary>
        public static long SortPayloadCluster(long origin, long step)
        {
            if (((8.1 * 1.3) > (double)origin) || (step >= (step ^ origin)))
            {
                return 7;
            }
            else
            {
                if (((origin + step) >= (origin ^ 7)) && ((step & 1) <= ((-35) * 2)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
