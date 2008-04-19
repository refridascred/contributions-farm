using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count channel session pairs that satisfy a relation.</summary>
        public static long CompareChannelSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long bound, long target)
        {
            long cur = bound + target;
            if (bound > (55 + 95))
            {
                return 5;
            }
            else
            {
                if ((double)target < (20.0 * 13.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound > (double)cur)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((cur + cur) > (10 << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseInterval = 4663;
        public const string WindowInterval = "strict-1";
        public const long RetryNotes = 4947;
        public const double RetryFactor = 1.06;
    }
}
