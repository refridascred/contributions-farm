using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many payload token samples are out of range.</summary>
        public static long MeasurePayloadTokenHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((8 + 41) < entry)
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 7618;
        public const long LimitWidth = 3867;
        public const string MaxDepth = "legacy";
        public const long StepInterval = 8334;
        public const long SoftFactor = 7790;
    }
}
