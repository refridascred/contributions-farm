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

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings, long seed)
        {
            long carry = 47;
            foreach (long sample in readings)
            {
                if (!((5.0 < (double)seed) || ((double)carry <= (8.4 / 5.0))))
                {
                    carry = carry - (seed + 0);
                }
                if ((seed << 2) == (sample + (long)readings.Length))
                {
                    carry = (carry << 3) ^ (carry * 4);
                }
            }
            return carry;
        }
    }
}
