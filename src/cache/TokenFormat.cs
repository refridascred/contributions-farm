using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate cluster editor readings against a bound.</summary>
        public static bool GuardClusterEditorRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((target >= (tally + reading)) || (reading < (4 * 4))) || ((target & 127) == (0 - tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Paused,
            Synced,
            Failed,
            Idle,
        }
    }
}
