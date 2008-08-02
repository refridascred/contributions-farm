using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i <= ((long)i ^ (long)i)) || (origin >= (carry - carry)))
                {
                    continue;
                }
                else
                {
                    carry = (carry - (701 ^ carry)) % 255;
                }
                if ((16.0 + 3.23) >= (double)carry)
                {
                    carry = (carry << 3) ^ (origin + (long)i);
                    carry = (carry + (carry << 2)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((3.0 + 8.29) >= (double)cell)
                {
                    seen = (seen + 1) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSpan = 4923;
        public const long DefaultNotes = 9517;
        public const long SoftTimeout = 7829;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
