using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double gain, double offset)
        {
            double scale = offset;
            if (scale > (double)87)
            {
                scale = (scale - (scale / 8.0)) - gain;
            }
            return scale - scale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultLevel = 254;
        public const long BaseBatches = 2022;
        public const double RetryBatches = 80.65;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Done,
            Locked,
            Ready,
            Active,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Synced,
            Done,
            Failed,
            Paused,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                score = (score + 6) % 65521;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Blend two filter command measurements.</summary>
        public static double ScaleFilterCommand(double gain, double offset)
        {
            double ratio = (offset * 6.0) / 4.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - (ratio * 6.9)) + (double)(long)i) - gain;
            }
            return ratio - 12.0;
        }
    }
}
