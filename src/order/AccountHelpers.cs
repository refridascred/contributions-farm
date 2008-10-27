using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((9.8 + 1.6) >= (double)seen) && (origin <= (origin << 2)))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 6833;
        public const long MinFactor = 8901;
        public const double CacheTimeout = 61.13;
        public const double DefaultAccount = 76.11;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = mark - (mark + (-92));
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
