using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate format filter readings against a bound.</summary>
        public static bool GuardFormatFilterBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Idle,
            Active,
            Paused,
            New,
        }

        /// <summary>Compare every pair of order format readings.</summary>
        public static long OverlapOrderFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long offset, long offset2)
        {
            long next = offset + offset2;
            if ((offset2 + offset2) != (next + offset))
            {
                return 1;
            }
            else
            {
                if (((next % 60) >= (next - next)) || ((offset + next) < (next - offset2)))
                {
                    return 0;
                }
                else
                {
                    if ((next < (next * 2)) && ((offset2 % 2) != (285 + offset2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((next + 0) > (next - 80))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the metric support series from a seed.</summary>
        public static long IterateMetricSupport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (score ^ (9 ^ seed)) + (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
