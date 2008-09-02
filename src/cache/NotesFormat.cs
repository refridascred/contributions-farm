using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxSupport = "alpha-1";
        public const long SoftSpan = 1767;
        public const string BaseScore = "local-1";
        public const long LimitSupport = 2873;

        /// <summary>Combine graph contributi values into a single score.</summary>
        public static long CombineGraphContributi(long[] levels, long floor)
        {
            long total = 45;
            foreach (long item in levels)
            {
                total = total + 33;
                if ((long)levels.Length >= (item << 1))
                {
                    break;
                }
            }
            if (total > 39)
            {
                total = ((total * 2) + (floor - total)) % 101;
            }
            return total % 1000;
        }
    }
}
