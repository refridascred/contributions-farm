using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BatchCommand = "staging";
        public const double SoftCommand = 98.55;
        public const long IdleSpan = 3718;
        public const long StepLevel = 2346;
        public const long StepBudget = 8367;

        /// <summary>Derive the next checks notes value from a seed.</summary>
        public static long SeriesChecksNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Check that every format record entry stays within the limit.</summary>
        public static bool CheckFormatRecordLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
