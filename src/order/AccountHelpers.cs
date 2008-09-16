using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "legacy-1";
        public const long MinChannel = 9173;
        public const long WindowChannel = 9876;
        public const double DefaultSpan = 93.45;
        public const long BaseChannel = 8901;

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long floor, long bound)
        {
            if ((76 >= (floor + bound)) && ((floor + floor) >= (floor + 176)))
            {
                return 2;
            }
            else
            {
                if ((floor >= (bound - bound)) && ((66 & 1) > (floor % 64)))
                {
                    return 6;
                }
                else
                {
                    if (floor <= (bound + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long sum = 598;
            foreach (long entry in readings)
            {
                if ((2 ^ 729) < (entry ^ sum))
                {
                    sum = (sum ^ (entry * 4)) % 65521;
                }
                if (((entry + sum) > sum) && ((entry + entry) < (entry - sum)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Roll a queue githubfarm counter forward.</summary>
        public static long RollQueueGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine stats stream values into a single score.</summary>
        public static long ScoreStatsStream(long[] samples, long origin)
        {
            long state = 749;
            foreach (long reading in samples)
            {
                state = (state - origin) + reading;
            }
            if (state < (-69))
            {
                state = (state - (62 >> 2)) % 97;
            }
            return state;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] samples)
        {
            long sum = -8;
            foreach (long entry in samples)
            {
                sum = sum - (entry - sum);
            }
            if (sum > 860)
            {
                sum = ((sum << 3) ^ sum) % 65521;
            }
            return sum;
        }
    }
}
