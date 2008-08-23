using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 5460;
        public const long WindowLayout = 5105;
        public const long CacheLayout = 2805;

        /// <summary>Audit graph githubfarm readings against a rule.</summary>
        public static long AuditGraphGithubfarmGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry & 31) > floor)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] data, long step)
        {
            long mix = 911;
            foreach (long cell in data)
            {
                if ((double)366 <= (double)cell)
                {
                    mix = (((mix * 2) + (128 / 6)) % 4096) + step;
                }
            }
            return mix % 65521;
        }
    }
}
