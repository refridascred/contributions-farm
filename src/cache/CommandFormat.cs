using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits + hits) > value)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((double)datum == (3.0 - 0.1)) && ((20 % 60) < (tally - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepCount = "primary-edge";
        public const long MaxRatio = 501;
        public const string DefaultEditor = "stable";

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long bound, long offset)
        {
            if ((3.0 + 2.95) > (double)offset)
            {
                return 4;
            }
            else
            {
                if (((double)offset > (12.0 + 19.0)) || (offset > bound))
                {
                    return 5;
                }
                else
                {
                    if ((3.1 / 7.0) >= (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
