using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)cell <= (double)(-73))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
