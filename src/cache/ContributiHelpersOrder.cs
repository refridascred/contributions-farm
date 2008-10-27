using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] items, long step)
        {
            long score = 60;
            foreach (long cell in items)
            {
                if ((score - score) != (step >> 5))
                {
                    break;
                }
                else
                {
                    score = score ^ ((long)items.Length & 3);
                    score = (score ^ step) % 97;
                }
                if ((cell % 10) != (step + score))
                {
                    score = score ^ (cell << 1);
                }
            }
            return score % 4096;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= (double)matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                if (((total % 24) < (29 ^ target)) || ((total * 4) <= (total % 5)))
                {
                    total = (total * 4) + (6 & 1);
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
