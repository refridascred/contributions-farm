using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] samples, long step)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                long count = (step * 3) + (entry + 9);
                score = (score * 4) + (count / 3);
                score = (score ^ (step & 63)) % 101;
            }
            if (score > 799)
            {
                score = ((score << 3) ^ (score >> 1)) % 4096;
            }
            return score;
        }

        /// <summary>Grade a context report value against two limits.</summary>
        public static long GradeContextReport(long seed, long step)
        {
            if (!(18.0 <= (double)seed))
            {
                return 2;
            }
            else
            {
                if ((1.9 / 3.0) == (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((step + step) != (seed - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit cache stream readings against a rule.</summary>
        public static long CountCacheStreamMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)sample <= (4.5 / 9.0))
                {
                    seen = (seen + 2) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of context cache readings.</summary>
        public static long CompareContextCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell ^ 87) > (cell & 63))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
