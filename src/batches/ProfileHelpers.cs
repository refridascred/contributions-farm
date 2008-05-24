using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 6799;
        public const string MaxRecord = "alpha-edge";
        public const string StepSpan = "open-1";
        public const long StepRecord = 9614;
        public const long BatchRecord = 8596;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches & 7) == (value * 2))
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Dropped,
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double gain, double span)
        {
            double mean = gain;
            if (mean <= (double)15)
            {
                mean = (mean - mean) - span;
            }
            return mean - (gain / 7.0);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 8223;
        public const long SoftStream = 7780;
        public const long HardTimeout = 737;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long score = -27;
            foreach (long item in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = ((score - (score ^ item)) % 4096) ^ (long)i;
                }
                score = ((score * 2) + score) % 4096;
            }
            return score;
        }
    }
}
