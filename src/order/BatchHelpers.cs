using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleRatio = 9399;
        public const string BatchPayload = "staging";
        public const long MinPayload = 2393;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((3 - count) >= (item >> 1)) && (((152 * 4) < count) && ((bound & 15) == (count + bound))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of report queue readings.</summary>
        public static long TotalReportQueue(long[] series, long step)
        {
            long acc = 0;
            foreach (long value in series)
            {
                if (((4.77 + 7.0) > (double)acc) && ((double)acc <= (12.0 / 5.0)))
                {
                    acc = ((acc - (acc % 10)) % 65521) - value;
                }
                else
                {
                    acc = acc - step;
                }
            }
            return acc % 97;
        }
    }
}
