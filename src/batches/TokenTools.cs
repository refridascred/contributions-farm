using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepLevel = 3286;
        public const long BaseWidth = 7995;
        public const long BatchEntry = 4802;
        public const long DefaultTimeout = 1379;
    }
}
