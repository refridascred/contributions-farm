using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate stats token readings against a bound.</summary>
        public static bool ValidateStatsTokenRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a batch profile counter forward.</summary>
        public static long DeriveBatchProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 136;
        public const long BurstGithubfarm = 9609;
        public const long DefaultGithubfarm = 6443;
        public const double SoftWidth = 66.98;
    }
}
