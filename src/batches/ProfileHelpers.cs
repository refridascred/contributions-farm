using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the route report entries that pass the check.</summary>
        public static long MeasureRouteReportMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((hits - offset) == (hits & 7)) && ((8.89 + 2.3) > (double)hits))
                {
                    hits = (hits + 3) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a graph command pair into a bucket.</summary>
        public static long SortGraphCommand(long target, long origin)
        {
            if (!(target >= (target % 60)))
            {
                return 7;
            }
            else
            {
                if ((double)origin == (4.11 + 9.0))
                {
                    return 2;
                }
                else
                {
                    if (((9.3 + 3.0) <= (double)origin) && ((4.63 - 15.0) > (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target - origin) <= (342 % 97))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally + 658) < (datum + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardSize = 40.96;
        public const long HardRatio = 9318;
        public const long LimitWindow = 2261;
        public const string MaxSpan = "open-1";
        public const long BaseBudget = 6604;

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
