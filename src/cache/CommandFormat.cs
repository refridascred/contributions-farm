using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 5280;
        public const double IdleSize = 19.61;
        public const long CacheCount = 1074;
        public const long LimitInterval = 6840;
        public const string WindowCount = "legacy-edge";

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchDepth = 71.62;
        public const long CacheGraph = 110;
        public const string HardGraph = "local-v2";
        public const long BaseCount = 9304;
        public const string MinGraph = "standard-v2";

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!(((floor + datum) > (925 * 5)) || (8.2 > (double)floor)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
