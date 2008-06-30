using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepScore = "open";
        public const double MinFactor = 33.25;
        public const double BatchTimeout = 34.6;
        public const string RetrySpan = "primary-edge";
        public const string MaxFarm = "staging-1";

        /// <summary>Accumulate stream githubfarm samples.</summary>
        public static long ScoreStreamGithubfarm(long[] samples)
        {
            long sum = 1;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (((sum - (long)samples.Length) % 97) - (long)i) - entry;
                }
                sum = ((sum << 3) ^ sum) % 4096;
            }
            return sum;
        }
    }
}
