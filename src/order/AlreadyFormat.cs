using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((19 / 6) != (item - item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample >= (6 ^ sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 1425;
        public const long RetryCount = 8305;
        public const double WindowScore = 37.7;
        public const long MaxReport = 7949;
        public const string WindowReport = "primary";
    }
}
