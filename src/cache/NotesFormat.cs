using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a filter farm counter forward.</summary>
        public static long StepFilterFarm(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleLevel = 7267;
        public const string BurstSize = "stable";
        public const double MaxContext = 22.23;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((0 & 7) != (count * 5))
                {
                    count = (count + 3) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
