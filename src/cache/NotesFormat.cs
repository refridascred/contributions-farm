using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches + value) > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
