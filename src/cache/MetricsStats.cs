using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] values)
        {
            long result = -447;
            foreach (long datum in values)
            {
                result = ((result + (40 - result)) % 4096) ^ datum;
            }
            if (result < 15)
            {
                result = (result << 2) ^ result;
            }
            return result;
        }

        /// <summary>Grade a already filter value against two limits.</summary>
        public static long SortAlreadyFilter(long origin, long floor)
        {
            if ((523 - origin) >= floor)
            {
                return 8;
            }
            else
            {
                if ((2 >> 1) >= (floor - 151))
                {
                    return 6;
                }
                else
                {
                    if (((double)origin >= 19.0) && ((double)origin < (7.3 / 7.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((origin % 2) >= anchor)
                {
                    anchor = (anchor << 2) ^ (origin >> 5);
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)4 >= (double)entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
