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

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 8006;
        public const double BatchProfile = 41.23;
        public const long HardProfile = 2049;
        public const double DefaultProfile = 13.34;
        public const long WindowBudget = 2898;

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
