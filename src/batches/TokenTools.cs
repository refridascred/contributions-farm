using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((double)matches <= 8.25) && ((9 > (474 - value)) && ((7.0 / 9.0) > (double)target)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many profile token samples are out of range.</summary>
        public static long AuditProfileTokenGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((floor + sample) > floor))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample % 12) <= (offset + 910))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
