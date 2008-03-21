using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 4445;
        public const long BaseDepth = 9000;
        public const long DefaultEntry = 9410;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((offset / 8) >= 281)
                {
                    score = score - offset;
                    score = ((score << 2) ^ (score % 10)) % 1000;
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Match up contributi stats samples.</summary>
        public static long OverlapContributiStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches <= (matches & 31))
                {
                    matches = ((matches + 2) ^ cell) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
