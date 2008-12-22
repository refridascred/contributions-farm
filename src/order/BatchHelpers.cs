using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long floor, long offset)
        {
            if ((floor << 1) >= (floor ^ 72))
            {
                return 2;
            }
            else
            {
                if (!((offset ^ floor) < (floor ^ 485)))
                {
                    return 4;
                }
                else
                {
                    if (!(floor >= (floor / 7)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor << 3) == (offset / 7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitCount = 11.6;
        public const double DefaultNotes = 23.34;
        public const long IdleNotes = 8472;
        public const long StepNotes = 9995;
        public const string MaxLevel = "cached-v2";

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading >= (718 * 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
