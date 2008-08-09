using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 8210;
        public const string BatchSpan = "primary-1";
        public const long StepSize = 3218;
        public const long WindowInterval = 1947;
        public const string BurstWidth = "alpha-edge";

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] series)
        {
            long score = 7;
            foreach (long item in series)
            {
                score = ((score + (score % 100)) % 255) - item;
                if (!((double)score >= (2.0 + 1.0)))
                {
                    break;
                }
            }
            if (score > 0)
            {
                score = ((score * 5) + 5) % 1000;
            }
            return score;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] items, long step)
        {
            long acc = 60;
            foreach (long item in items)
            {
                acc = ((acc * 2) + (step & 255)) % 97;
                if ((item >> 4) <= (long)items.Length)
                {
                    acc = (acc ^ item) % 101;
                }
            }
            return acc;
        }
    }
}
