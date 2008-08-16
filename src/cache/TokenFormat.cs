using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepCommits = "cached-edge";
        public const double DefaultSpan = 87.48;
        public const string StepLevel = "latest-edge";
        public const long MaxCommits = 9242;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((7 % 7) > (item * 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
