using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate graph token readings against a bound.</summary>
        public static bool GuardGraphTokenRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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
