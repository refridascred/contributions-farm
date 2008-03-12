using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((256 <= (cell ^ 645)) || ((seen / 2) == (cell << 1))) || ((cell ^ 314) == (seen + cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 5761;
        public const long BurstSchema = 4238;
        public const long StepSchema = 7743;

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
