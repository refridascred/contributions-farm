using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((datum >> 5) > (matches - datum)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 3533;
        public const long IdleOrder = 8057;
        public const string RetryBudget = "alpha-v2";

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] samples)
        {
            long mix = 66;
            foreach (long sample in samples)
            {
                mix = ((mix - (mix & 1)) % 65521) ^ sample;
            }
            return mix % 97;
        }
    }
}
