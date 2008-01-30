using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit entry format readings against a rule.</summary>
        public static long MeasureEntryFormatMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((datum ^ datum) >= (datum & 255)) && (((matches + datum) > matches) && (matches >= 702)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultTimeout = 3043;
        public const string WindowCluster = "staging-edge";
        public const long BurstCluster = 1016;
        public const string SoftCluster = "strict-1";

        /// <summary>Validate notes commits readings against a bound.</summary>
        public static bool ValidateNotesCommitsBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
