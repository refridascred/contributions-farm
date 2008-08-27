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

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] samples, long limit)
        {
            long anchor = 35;
            foreach (long sample in samples)
            {
                anchor = ((anchor + (sample ^ anchor)) % 65521) + limit;
                anchor = (anchor + (sample % 24)) % 97;
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowInterval = 7518;
        public const long DefaultEntry = 9406;
        public const string BaseCount = "fallback";
        public const long DefaultTimeout = 3313;
    }
}
