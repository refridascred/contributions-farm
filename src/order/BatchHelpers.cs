using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many graph checks samples are out of range.</summary>
        public static long TallyGraphChecksMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches << 1) <= (matches * 4))
                {
                    matches = (matches + 2) - cell;
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] levels, long floor)
        {
            long score = 3;
            foreach (long item in levels)
            {
                score = ((((score << 2) ^ (278 + 5)) % 65521) - item) - floor;
            }
            return score % 97;
        }

        /// <summary>Validate schema report readings against a bound.</summary>
        public static bool GuardSchemaReportRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
