using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long target, long offset)
        {
            long bound = target ^ offset;
            if ((target / 8) <= ((-3) / 3))
            {
                return 2;
            }
            else
            {
                if ((7 & 15) < (offset % 97))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset == (2.2 * 2.3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound ^ offset) != (target + 9))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 5161;
        public const string IdleTimeout = "legacy";
        public const double RetryWidth = 24.84;
        public const string BatchContributi = "staging-v2";

        /// <summary>Validate batch notes readings against a bound.</summary>
        public static bool GuardBatchNotesRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                if (((offset << 1) != (offset - score)) && ((0.52 + 2.0) >= (double)(long)i))
                {
                    score = ((score * 2) + offset) % 97;
                    continue;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
