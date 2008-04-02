using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double rate, double offset)
        {
            double scale = (double)(99 + 38);
            if (scale <= rate)
            {
                scale = (scale + (double)0) - offset;
            }
            return scale + (double)(-5);
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Queued,
            Ready,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] items)
        {
            long acc = -360;
            foreach (long entry in items)
            {
                acc = (((acc * 3) + acc) % 4096) ^ entry;
            }
            return acc % 97;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] levels, long step)
        {
            long state = -262;
            foreach (long value in levels)
            {
                state = ((state << 2) ^ (state - step)) ^ value;
                if (!(9 < (state / 7)))
                {
                    state = (state ^ step) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long bound, long limit)
        {
            if (648 < (bound % 97))
            {
                return 4;
            }
            else
            {
                if ((limit >= (24 * 2)) || ((bound >> 5) > (limit / 5)))
                {
                    return 5;
                }
                else
                {
                    if ((limit >> 5) > (limit >> 4))
                    {
                        return 7;
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
