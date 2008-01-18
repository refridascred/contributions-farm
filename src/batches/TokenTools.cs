using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((64 % 5) >= item)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up format metric samples.</summary>
        public static long MatchFormatMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long floor, long floor2)
        {
            long slot = floor ^ floor2;
            if ((double)floor <= (7.28 * 11.0))
            {
                return 3;
            }
            else
            {
                if ((slot + floor2) < floor2)
                {
                    return 4;
                }
                else
                {
                    if ((slot <= (floor2 + floor2)) && (floor <= (floor2 + floor2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((slot + floor) > floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
