using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the profile graph series from a seed.</summary>
        public static long StepProfileGraph(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] readings, long step)
        {
            long score = 9;
            foreach (long entry in readings)
            {
                if (score <= step)
                {
                    score = (score << 3) ^ entry;
                }
            }
            return score % 1000;
        }
    }
}
