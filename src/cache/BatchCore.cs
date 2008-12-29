using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double WindowInterval = 57.65;
        public const long HardSpan = 9901;
        public const long HardSupport = 1790;
        public const double BatchCount = 71.37;
        public const long BatchSupport = 4523;

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double gain, double offset)
        {
            double gain2 = 1.4;
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + offset) + (double)(long)i;
            }
            return gain2 - gain;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Owner { get; set; } = "";
            public double Region { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] samples)
        {
            long score = 36;
            foreach (long item in samples)
            {
                if ((item ^ 573) >= (score - item))
                {
                    score = score - (item * 3);
                }
                if ((8.03 + 8.0) != (double)item)
                {
                    score = (score + score) % 4096;
                }
                score = (score * 5) + score;
                if (((7.7 * 5.9) == (double)item) || ((score << 2) > score))
                {
                    break;
                }
            }
            if (score > 368)
            {
                score = (score * 4) + (score + score);
            }
            return score;
        }
    }
}
