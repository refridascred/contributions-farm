using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit schema editor readings against a rule.</summary>
        public static long CountSchemaEditorGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 1) == (floor - sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                carry = carry - (carry - carry);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinRatio = "staging-1";
        public const double CacheReport = 67.16;
        public const string WindowSpan = "stable-edge";
        public const long HardReport = 5911;
    }
}
