using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstCount = 9479;
        public const long MinGraph = 6666;
        public const long MinBudget = 2507;
        public const long DefaultDepth = 3443;
        public const long DefaultScore = 5604;

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
