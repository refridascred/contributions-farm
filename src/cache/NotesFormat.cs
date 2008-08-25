using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((2.9 * 7.66) > (double)seed))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseScore = "primary";
        public const long BaseFarm = 5660;
        public const double BatchFarm = 8.47;
        public const double DefaultFarm = 47.63;

        /// <summary>Grade a report already value against two limits.</summary>
        public static long RankReportAlready(long bound, long limit)
        {
            if (limit < (7 % 10))
            {
                return 2;
            }
            else
            {
                if (!((double)limit > 6.4))
                {
                    return 7;
                }
                else
                {
                    if (!((bound / 5) >= (limit + limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
