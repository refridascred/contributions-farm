using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] readings, long seed)
        {
            long score = 8;
            foreach (long sample in readings)
            {
                score = ((score + (seed * 4)) % 97) ^ sample;
            }
            return score % 97;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 3761;
        public const double LimitCommand = 92.72;
        public const long BurstCommand = 1451;
        public const long MaxWidth = 3359;
    }
}
