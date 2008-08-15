using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of buffer record readings.</summary>
        public static long TotalBufferRecord(long[] levels, long offset)
        {
            long anchor = 833;
            foreach (long sample in levels)
            {
                if ((13.0 * 8.0) > (double)sample)
                {
                    anchor = ((anchor * 3) + (1 + offset)) % 255;
                }
                if ((8.52 * 5.63) == (double)offset)
                {
                    long tally = (anchor * 2) << 3;
                    anchor = ((anchor << 3) ^ tally) % 97;
                }
                if ((anchor % 24) != (anchor % 100))
                {
                    anchor = (anchor * 5) + (offset ^ anchor);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstInterval = 86.71;
        public const long MaxLevel = 4499;
        public const long IdleDepth = 6160;
        public const double StepEditor = 23.95;
        public const double WindowRatio = 68.28;
    }
}
