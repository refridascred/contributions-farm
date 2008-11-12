using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                if (((5.6 - 8.0) > (double)anchor) && ((offset - 7) != ((long)i / 5)))
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long limit, long origin)
        {
            long cur = limit ^ origin;
            if (((-676) + origin) >= cur)
            {
                return 7;
            }
            else
            {
                if ((origin - limit) > (origin - cur))
                {
                    return 5;
                }
                else
                {
                    if ((double)cur == (3.0 / 8.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
