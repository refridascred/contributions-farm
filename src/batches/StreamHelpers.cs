using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((((tally + datum) >= (-703)) || ((tally + datum) == (datum - tally))) && ((datum / 3) == (tally + datum)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long origin, long limit)
        {
            long slot = origin + limit;
            if ((slot < 27) && ((78 - 12) > limit))
            {
                return 8;
            }
            else
            {
                if ((limit ^ slot) <= limit)
                {
                    return 2;
                }
                else
                {
                    if ((95 + 887) != (origin + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next cluster schema value from a seed.</summary>
        public static long IterateClusterSchema(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = acc + (target + target);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Locate a tools route reading by value.</summary>
        public static long FindToolsRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchTimeout = 7632;
        public const string IdleSpan = "cached-edge";
        public const long DefaultPayload = 1303;
        public const string BaseInterval = "primary-edge";
    }
}
