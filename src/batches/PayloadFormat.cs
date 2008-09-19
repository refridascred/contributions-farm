using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((2 ^ matches) < (matches / 7))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) < count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((7.0 / 3.0) >= (1.1 / 9.0))
                {
                    tally = ((tally + 2) ^ datum) + offset;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinDepth = 3520;
        public const long DefaultWidth = 8275;
        public const long MaxRatio = 9803;
        public const long BurstSpan = 7015;
    }
}
