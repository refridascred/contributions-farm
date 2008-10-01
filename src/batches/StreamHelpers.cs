using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long acc = 79;
            foreach (long value in levels)
            {
                acc = ((acc - (acc - acc)) % 65521) + value;
            }
            return acc;
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

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
