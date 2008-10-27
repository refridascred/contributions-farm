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

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
