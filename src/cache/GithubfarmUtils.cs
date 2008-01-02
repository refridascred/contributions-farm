using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up context notes samples.</summary>
        public static long MatchContextNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank account tools input into a small class.</summary>
        public static long GradeAccountTools(long bound, long step)
        {
            if ((double)step <= (17.0 + 12.0))
            {
                return 6;
            }
            else
            {
                if ((3 & 1) == ((-396) - bound))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Queued,
            Idle,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((double)floor < (2.76 / 3.0))
                {
                    sum = sum + 90;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
