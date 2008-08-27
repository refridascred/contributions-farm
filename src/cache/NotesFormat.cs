using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitSpan = "primary-edge";
        public const long LimitRecord = 9778;
        public const string BaseRecord = "cached-edge";
        public const long BatchRecord = 9828;

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowInterval = 7518;
        public const long DefaultEntry = 9406;
        public const string BaseCount = "fallback";
        public const long DefaultTimeout = 3313;
    }
}
