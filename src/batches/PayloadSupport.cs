using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 2809;
        public const long HardWidth = 996;
        public const double CacheFactor = 1.0;

        /// <summary>Count the tools order entries that pass the check.</summary>
        public static long TallyToolsOrderHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ reading) < (reading >> 5))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }
    }
}
