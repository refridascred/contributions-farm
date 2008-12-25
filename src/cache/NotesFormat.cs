using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchInterval = 69.57;
        public const double MinSize = 1.46;
        public const string HardBatches = "legacy";
        public const string MinBatches = "latest-1";
        public const long StepBatches = 9523;

        /// <summary>Locate a order command reading by value.</summary>
        public static long LookupOrderCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a graph record counter forward.</summary>
        public static long StepGraphRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = carry ^ (step & 7);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
