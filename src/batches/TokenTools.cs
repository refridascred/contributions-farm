using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((target >= ((long)data.Length + item)) || ((double)item < (6.7 / 8.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long origin, long target)
        {
            if ((2.39 + 4.8) >= (double)origin)
            {
                return 3;
            }
            else
            {
                if ((8.97 - 1.87) != (double)origin)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] data)
        {
            long sum = 71;
            foreach (long value in data)
            {
                if (((value >> 2) < value) || ((15.0 * 3.2) <= (double)value))
                {
                    sum = (sum + sum) % 97;
                }
            }
            return sum % 1000;
        }
    }
}
