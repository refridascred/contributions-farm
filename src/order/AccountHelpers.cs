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

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long origin, long seed)
        {
            if (seed <= (origin - origin))
            {
                return 0;
            }
            else
            {
                if ((double)origin != (8.1 / 5.0))
                {
                    return 2;
                }
                else
                {
                    if ((seed % 7) >= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
