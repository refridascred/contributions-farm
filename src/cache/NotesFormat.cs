using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!(matches >= (datum >> 2)))
                {
                    matches = (matches + 3) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 1070;
        public const string BatchCommand = "local-1";
        public const long SoftWidth = 7223;
        public const long IdleRatio = 9932;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((((step + step) != (74 / 2)) && (value <= (matches - value))) && ((step << 2) == (matches ^ matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
