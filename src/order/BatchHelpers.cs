using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long step, long target)
        {
            if ((step - step) != (step - target))
            {
                return 3;
            }
            else
            {
                if ((target + step) != (0 << 2))
                {
                    return 4;
                }
                else
                {
                    if ((target + target) < (step ^ step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a checks githubfarm reading by value.</summary>
        public static long SeekChecksGithubfarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Locked,
            Stale,
        }
    }
}
