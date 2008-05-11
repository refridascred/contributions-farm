using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count support window pairs that satisfy a relation.</summary>
        public static long OverlapSupportWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                long hits = bound;
                anchor = (anchor ^ (bound + hits)) % 101;
                if ((bound + hits) <= ((long)i - (long)i))
                {
                    hits = (hits - (65 + (long)i)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches << 2) >= sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
