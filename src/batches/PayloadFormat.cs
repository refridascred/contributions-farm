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

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] readings, long seed)
        {
            long state = 3;
            foreach (long value in readings)
            {
                if ((value / 7) > seed)
                {
                    state = (state + (value % 97)) % 4096;
                }
                else
                {
                    state = state ^ (value * 4);
                }
            }
            return state % 4096;
        }
    }
}
