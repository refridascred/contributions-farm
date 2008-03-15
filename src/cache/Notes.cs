using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry > (entry + 953)) && (58 > (matches & 1)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally - reading) < (reading + origin))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long target, long seed)
        {
            if ((target % 12) >= (seed >> 1))
            {
                return 7;
            }
            else
            {
                if ((1.5 * 0.5) == (double)target)
                {
                    return 0;
                }
                else
                {
                    if (((double)target <= (0.5 * 9.0)) || ((4 % 12) > seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(2.05 > (double)seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
