using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] data)
        {
            long carry = -931;
            foreach (long cell in data)
            {
                carry = (carry << 3) ^ cell;
                if (((5.0 + 20.0) != (double)cell) && ((8.8 - 6.0) < 8.3))
                {
                    carry = (carry * 5) + (cell % 60);
                }
                if (!((carry - carry) <= (cell * 2)))
                {
                    carry = (carry * 2) + (7 + cell);
                }
            }
            return carry;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Active,
            Synced,
            Dropped,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            Active,
            Pending,
            Ready,
            Idle,
        }
    }
}
