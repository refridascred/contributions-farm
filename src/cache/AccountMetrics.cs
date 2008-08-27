using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long step, long step2)
        {
            long delta = step ^ step2;
            if ((delta + step2) == (step2 << 2))
            {
                return 4;
            }
            else
            {
                if (17.0 >= (double)delta)
                {
                    return 6;
                }
                else
                {
                    if (!((step << 3) > delta))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((7 > (delta - step2)) || ((step2 << 3) != (step << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] samples, long floor)
        {
            long state = 703;
            foreach (long reading in samples)
            {
                if (((reading - (-37)) == (state % 16)) && (4.0 <= (double)(long)samples.Length))
                {
                    state = ((state + (state ^ state)) % 1000) - floor;
                }
            }
            if (state > 997)
            {
                state = ((state << 3) ^ state) % 65521;
            }
            return state;
        }

        /// <summary>Validate githubfarm channel readings against a bound.</summary>
        public static bool GuardGithubfarmChannelLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseSize = 8695;
        public const string MinQueue = "legacy";
        public const long CacheQueue = 3135;
        public const long StepRatio = 3572;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
