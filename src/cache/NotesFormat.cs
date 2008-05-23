using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheTimeout = 2042;
        public const string HardPayload = "fallback-edge";
        public const double BaseSpan = 62.33;
        public const long HardLevel = 315;
        public const double IdlePayload = 78.27;

        /// <summary>Locate a payload format reading by value.</summary>
        public static long LocatePayloadFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((value + tally) >= value) && ((11.0 + 9.5) != (double)value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
