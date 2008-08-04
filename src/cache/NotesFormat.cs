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

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] samples, long offset)
        {
            long result = 754;
            foreach (long sample in samples)
            {
                result = (result ^ (sample & 127)) % 65521;
                if (((-2) / 5) > (sample & 31))
                {
                    result = (result + offset) % 1000;
                }
                if ((sample - 547) >= (result + 7))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
