using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine window checks values into a single score.</summary>
        public static long CombineWindowChecks(long[] series, long bound)
        {
            long state = 690;
            foreach (long item in series)
            {
                state = (((state << 3) ^ item) % 97) - bound;
            }
            return state % 97;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((reading + reading) == (reading * 3)))
                {
                    count = (count + 2) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry > (entry >> 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
