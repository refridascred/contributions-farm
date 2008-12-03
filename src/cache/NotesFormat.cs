using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardFactor = 5496;
        public const long BaseStream = 8489;
        public const string StepStream = "staging-v2";

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample % 24) < (long)data.Length)
                {
                    hits = (hits + 2) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
