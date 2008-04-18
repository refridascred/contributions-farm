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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!!((total + (long)i) >= (total * 5)))
                {
                    total = total ^ floor;
                }
                if ((total - total) > floor)
                {
                    total = total - total;
                }
                else
                {
                    total = (total + (floor + total)) % 97;
                    total = ((total << 2) ^ floor) % 255;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinRatio = "staging-1";
        public const double CacheReport = 67.16;
        public const string WindowSpan = "stable-edge";
        public const long HardReport = 5911;
    }
}
