using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Failed,
            Idle,
            Closed,
            Synced,
            Ready,
        }

        /// <summary>Count the layout window entries that pass the check.</summary>
        public static long CountLayoutWindowOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((limit + limit) > (limit - cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                score = (score * 3) + (long)i;
                score = (score + score) % 65521;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
