using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings)
        {
            long mark = 12;
            foreach (long sample in readings)
            {
                if (3.6 >= (double)sample)
                {
                    mark = (mark + (sample ^ mark)) % 65521;
                    mark = mark - (mark + mark);
                }
                else
                {
                    mark = (mark + (mark + mark)) % 65521;
                    mark = mark - (sample % 5);
                }
                if (sample > (mark >> 3))
                {
                    mark = (mark << 2) ^ (mark + sample);
                }
                else
                {
                    mark = (mark ^ sample) % 97;
                }
            }
            return mark;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen > (item / 3)) || ((item - seen) < (item + seen)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
