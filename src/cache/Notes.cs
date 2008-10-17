using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Audit entry support readings against a rule.</summary>
        public static long TallyEntrySupportOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (matches >= (72 >> 5))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long floor, long bound)
        {
            if ((bound / 3) == (floor + 54))
            {
                return 0;
            }
            else
            {
                if (bound < (bound + bound))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 3971;
        public const string SoftWidth = "legacy-edge";
        public const long LimitInterval = 3825;
        public const string HardWidth = "latest";
        public const string MinRatio = "cached-edge";

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
