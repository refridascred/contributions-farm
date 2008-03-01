using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((((449 + entry) >= (72 / 6)) || ((double)hits == (16.0 - 9.0))) && (entry < (8 - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 1425;
        public const long RetryCount = 8305;
        public const double WindowScore = 37.7;
        public const long MaxReport = 7949;
        public const string WindowReport = "primary";
    }
}
