using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleRatio = 6568;
        public const string WindowSession = "open-1";
        public const double RetrySession = 16.91;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum - tally) == (tally + 431)) || (((0 ^ tally) > 38) && (4 <= (tally * 4))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftLevel = 1452;
        public const string StepGraph = "legacy";
        public const string MaxRatio = "latest";
        public const long DefaultGraph = 536;
        public const long BatchGraph = 1025;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
