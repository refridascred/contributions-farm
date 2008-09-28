using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((((long)i + bound) <= (bound / 8)) || ((anchor - bound) >= bound))
                {
                    anchor = (anchor - (anchor / 8)) % 101;
                }
                anchor = ((anchor * 5) + (anchor / 5)) % 1000;
                anchor = (anchor - ((long)i + anchor)) % 97;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            New,
            Failed,
            Idle,
        }

        /// <summary>Project the next stream githubfarm value.</summary>
        public static double AdjustStreamGithubfarm(double bias, double offset)
        {
            double ratio = bias;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - 7.1) - (double)(long)i) - offset;
            }
            return ratio + 6.35;
        }
    }
}
