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

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((457 + floor) <= seen))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
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
