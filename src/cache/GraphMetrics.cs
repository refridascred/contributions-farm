using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the filter report series from a seed.</summary>
        public static long RollFilterReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                if (!((bound >> 4) != (anchor / 8)))
                {
                    anchor = anchor + bound;
                }
                if (!(bound <= (74 >> 4)))
                {
                    anchor = anchor ^ (anchor * 2);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate session context readings against a bound.</summary>
        public static bool ValidateSessionContextLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading / 7) == (reading << 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardPayload = "open";
        public const double LimitPayload = 14.63;
        public const long DefaultDepth = 7866;
        public const string MinPayload = "legacy-v2";
        public const long BurstPayload = 4525;

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long bound, long origin)
        {
            long slot = bound - origin;
            if ((double)slot > (6.0 - 6.0))
            {
                return 3;
            }
            else
            {
                if (origin > (origin * 2))
                {
                    return 1;
                }
                else
                {
                    if (origin >= (slot << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
