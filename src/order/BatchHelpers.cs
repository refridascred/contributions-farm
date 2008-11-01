using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count <= (216 - sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "cached";
        public const string DefaultCache = "staging-v2";
        public const double BurstSize = 68.27;

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
