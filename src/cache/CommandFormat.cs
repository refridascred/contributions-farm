using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Dropped,
            Stale,
            New,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                score = (score * 2) + (score << 1);
                score = ((score << 3) ^ (score - score)) % 4096;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long bound, long bound2)
        {
            if (bound2 <= (bound2 ^ 5))
            {
                return 7;
            }
            else
            {
                if ((double)bound2 <= (double)837)
                {
                    return 4;
                }
                else
                {
                    if ((bound2 ^ bound2) != (bound2 << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((bound2 - bound) != (719 + bound)) && ((bound2 - bound2) > (bound2 + bound2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((seed / 6) <= matches))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }
    }
}
