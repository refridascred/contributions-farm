using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long target, long bound)
        {
            long step = target + bound;
            if (step <= (bound << 3))
            {
                return 0;
            }
            else
            {
                if ((bound + 94) <= (step * 5))
                {
                    return 5;
                }
                else
                {
                    if (target > (target + target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound == (2.0 / 5.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading - origin) >= (origin & 3))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count already stats pairs that satisfy a relation.</summary>
        public static long MatchAlreadyStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
