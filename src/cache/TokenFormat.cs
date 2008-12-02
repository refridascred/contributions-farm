using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long step, long offset)
        {
            if (step <= (379 * 3))
            {
                return 0;
            }
            else
            {
                if ((1.0 + 9.7) != (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((7.4 / 7.0) < (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen % 10) >= (entry >> 4))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }
    }
}
