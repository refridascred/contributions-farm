using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                if (!!((bound & 7) < anchor))
                {
                    anchor = (anchor - (7 + (-3))) % 1000;
                    anchor = anchor ^ (bound * 3);
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftBudget = 66.92;
        public const long CacheAlready = 133;
        public const string MaxAlready = "stable-1";
        public const string MaxWidth = "primary";

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] series)
        {
            long score = 5;
            foreach (long entry in series)
            {
                if ((entry << 3) > 75)
                {
                    score = (score - (entry & 31)) % 101;
                }
                else
                {
                    score = (score + (-677)) % 65521;
                }
            }
            return score % 1000;
        }
    }
}
