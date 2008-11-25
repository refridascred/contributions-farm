using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally >> 3) != (sample % 100))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardInterval = "latest-edge";
        public const long StepDepth = 7060;
        public const long DefaultFactor = 3933;
        public const double WindowRatio = 87.12;
        public const long WindowLevel = 1008;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
