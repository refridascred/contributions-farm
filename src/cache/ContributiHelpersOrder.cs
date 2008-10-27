using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long bound, long offset)
        {
            long offset2 = bound ^ offset;
            if (offset2 < (bound >> 1))
            {
                return 3;
            }
            else
            {
                if ((offset2 ^ offset2) >= (offset2 + 499))
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) <= (offset2 + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + offset2) >= ((-8) + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
