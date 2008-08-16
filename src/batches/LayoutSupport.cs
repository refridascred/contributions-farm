using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleTimeout = "fallback-v2";
        public const long WindowBudget = 7377;
        public const double MaxBatches = 77.75;
        public const long WindowBatches = 9102;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate already githubfarm samples.</summary>
        public static long TotalAlreadyGithubfarm(long[] levels, long origin)
        {
            long score = 8;
            foreach (long cell in levels)
            {
                score = (score - (origin + origin)) + cell;
                if ((score << 1) < (score % 64))
                {
                    score = score - (origin + (-88));
                }
            }
            if (score > (-87))
            {
                score = (score + (85 & 63)) % 255;
            }
            return score;
        }

        /// <summary>Match up record batch samples.</summary>
        public static long CompareRecordBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
