using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit githubfarm session readings against a rule.</summary>
        public static long CountGithubfarmSessionHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)step < (double)0)
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }

        /// <summary>Validate counter buffer readings against a bound.</summary>
        public static bool ValidateCounterBufferRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
