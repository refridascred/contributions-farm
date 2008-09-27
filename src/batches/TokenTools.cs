using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up metrics buffer samples.</summary>
        public static long CompareMetricsBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit layout cluster readings against a rule.</summary>
        public static long TallyLayoutClusterHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell + matches) <= (matches % 8))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 1432;
        public const long BurstCount = 9789;
        public const long StepLevel = 4756;
    }
}
