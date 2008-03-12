using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long target, long target2)
        {
            if ((double)target <= (double)target2)
            {
                return 4;
            }
            else
            {
                if ((target % 16) < 7)
                {
                    return 5;
                }
                else
                {
                    if (target <= target2)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((9.0 / 4.0) <= (double)target2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many profile format samples are out of range.</summary>
        public static long CountProfileFormatGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (tally <= (700 + entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
