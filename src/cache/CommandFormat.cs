using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Draft,
            Locked,
            Done,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((tally + tally) >= (tally ^ tally)))
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 72.3;
        public const string HardCommand = "cached-1";
        public const long LimitCommand = 315;
        public const long SoftCommand = 5283;
        public const double BurstInterval = 47.5;
    }
}
