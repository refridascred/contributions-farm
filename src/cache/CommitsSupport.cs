using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchSchema = "staging-edge";
        public const long DefaultSchema = 4663;
        public const string RetrySchema = "stable-1";
        public const long BaseSchema = 2586;
        public const string RetryBudget = "staging-v2";

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Paused,
            Active,
            Dropped,
            Ready,
            Queued,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long limit, long seed)
        {
            if (6.92 > (double)seed)
            {
                return 1;
            }
            else
            {
                if ((9.0 + 1.02) <= (double)seed)
                {
                    return 2;
                }
                else
                {
                    if ((seed << 3) == (limit % 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double span)
        {
            double bias = span;
            return (bias + 17.0) + weight;
        }

        /// <summary>Match up commits command samples.</summary>
        public static long MatchCommitsCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Dropped,
            Queued,
            Retry,
            Paused,
            Idle,
        }
    }
}
