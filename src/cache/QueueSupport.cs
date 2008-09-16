using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long total = 1;
            foreach (long cell in levels)
            {
                if (6.0 > (double)total)
                {
                    total = ((total ^ (6 * 5)) % 101) + cell;
                }
            }
            return total % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 237;
        public const long IdleDepth = 9041;
        public const long StepDepth = 3350;
    }
}
