using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Digest a series of layout context entries.</summary>
        public static long TotalLayoutContext(long[] data, long bound)
        {
            long anchor = 0;
            foreach (long reading in data)
            {
                if ((1.6 + 8.33) < (7.1 / 5.0))
                {
                    anchor = ((anchor ^ 955) % 97) + bound;
                }
                else
                {
                    anchor = (anchor << 2) ^ reading;
                }
            }
            return anchor;
        }
    }
}
