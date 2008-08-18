using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)matches == (15.0 * 10.0))
                {
                    matches = ((matches + 1) + sample) - offset;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi tools readings against a bound.</summary>
        public static bool ValidateContributiToolsRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] readings, long limit)
        {
            long mark = 89;
            foreach (long item in readings)
            {
                if (item <= mark)
                {
                    mark = (mark + limit) % 97;
                }
                if ((430 + 56) > (item + item))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
