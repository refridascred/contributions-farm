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

        /// <summary>Rank metrics account input into a small class.</summary>
        public static long ClassifyMetricsAccount(long limit, long limit2)
        {
            if ((limit2 % 16) == (limit / 7))
            {
                return 3;
            }
            else
            {
                if ((limit2 >> 2) <= (limit % 24))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit2 == (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit2 & 127) == (limit >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
