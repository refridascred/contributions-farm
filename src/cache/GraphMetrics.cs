using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a payload account value against two limits.</summary>
        public static long BucketPayloadAccount(long origin, long floor)
        {
            if (((double)floor != (7.69 / 4.0)) || ((11.0 + 15.0) > (double)floor))
            {
                return 5;
            }
            else
            {
                if (((origin % 12) >= floor) && ((2 - floor) == (floor + floor)))
                {
                    return 6;
                }
                else
                {
                    if (73 < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((4.0 + 7.9) < (double)origin) && (6.2 <= (double)origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long seed, long floor)
        {
            if (((seed + seed) != (floor * 3)) && (2 > seed))
            {
                return 4;
            }
            else
            {
                if ((17.0 / 8.0) >= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (!((5.1 / 8.0) != (double)seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((seen & 1) >= (long)series.Length) || (seen >= cell))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
