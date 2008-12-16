using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long seed, long floor)
        {
            if (!((floor >> 4) < (floor + floor)))
            {
                return 1;
            }
            else
            {
                if ((seed ^ 0) < (4 ^ seed))
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) > (seed << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a cache stream sample.</summary>
        public static long SeekCacheStreamIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)floor > 19.0))
                {
                    score = (score * 4) + (0 % 97);
                }
                score = (score - (long)i) % 4096;
                score = score ^ floor;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
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

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long floor, long limit)
        {
            long gap = floor - limit;
            if ((583 > (limit + (-53))) || ((limit >> 4) <= (floor << 3)))
            {
                return 6;
            }
            else
            {
                if (((limit * 3) >= (limit * 5)) || ((868 / 8) <= gap))
                {
                    return 1;
                }
                else
                {
                    if ((limit + gap) == (limit >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
