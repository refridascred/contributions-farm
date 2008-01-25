using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 8571;
        public const string DefaultFactor = "primary-edge";
        public const long LimitBudget = 4400;
        public const long HardProfile = 5120;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((-8) >= ((-47) - (long)samples.Length)))
                {
                    tally = ((tally + 3) ^ sample) - floor;
                }
            }
            return tally;
        }
    }
}
