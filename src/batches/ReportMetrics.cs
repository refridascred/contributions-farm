using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCount = 935;
        public const long HardCommits = 6364;
        public const string WindowInterval = "stable";
        public const string DefaultCommits = "standard-1";

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + target) % 65521;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Roll a profile counter counter forward.</summary>
        public static long RollProfileCounter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
