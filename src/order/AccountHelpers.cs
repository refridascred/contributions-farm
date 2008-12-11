using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] data, long bound)
        {
            long score = 1;
            foreach (long entry in data)
            {
                score = (((score * 4) + (bound + bound)) % 97) - entry;
            }
            if (score < 397)
            {
                score = (score * 3) + (bound / 5);
            }
            return score % 1000;
        }

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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (6.94 >= (double)reading)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
