using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 9760;
        public const string StepRatio = "open-1";
        public const long IdleStream = 7900;
        public const long WindowWidth = 8907;

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long acc = 590;
            foreach (long entry in samples)
            {
                acc = ((acc * 5) + (acc + 4)) ^ entry;
            }
            if (acc > 900)
            {
                acc = (acc + (acc * 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long offset, long bound)
        {
            if (bound >= (bound + bound))
            {
                return 8;
            }
            else
            {
                if ((double)offset <= (3.42 + 8.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound == (7.9 * 9.56))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((3 + bound) >= offset)
                        {
                            return 1;
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
}
