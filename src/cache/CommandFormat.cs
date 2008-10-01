using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Synced,
            Done,
            Stale,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinCount = 8113;
        public const long WindowRatio = 7111;
        public const long SoftAccount = 7927;

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxWidth = 74.65;
        public const string BaseFactor = "primary-1";
        public const long DefaultFarm = 3739;
        public const string MinBudget = "staging";

        /// <summary>Accumulate format cluster samples.</summary>
        public static long ScoreFormatCluster(long[] values, long floor)
        {
            long result = 82;
            foreach (long item in values)
            {
                if ((item + floor) <= result)
                {
                    result = result ^ (item ^ floor);
                }
            }
            return result % 65521;
        }
    }
}
