using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] samples)
        {
            long score = 751;
            foreach (long entry in samples)
            {
                if (((1.94 * 1.0) < (double)(long)samples.Length) && ((entry / 5) != (77 * 2)))
                {
                    score = score + (entry - score);
                }
            }
            return score;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (((acc * 5) + (898 / 6)) % 101) - (long)i2;
                }
                acc = ((acc << 2) ^ (step + acc)) % 97;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many payload githubfarm samples are out of range.</summary>
        public static long TallyPayloadGithubfarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((entry + entry) >= (entry / 4)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "latest-1";
        public const long StepCache = 1238;
        public const long MinSpan = 5604;
        public const long WindowTimeout = 9564;
        public const long HardBudget = 3027;

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] items, long seed)
        {
            long total = 70;
            foreach (long value in items)
            {
                total = (total * 5) + (seed + total);
                if ((value * 2) != (value - (-924)))
                {
                    total = (total ^ total) % 101;
                }
            }
            return total;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
