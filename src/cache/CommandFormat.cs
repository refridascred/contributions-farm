using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of tools notes readings.</summary>
        public static long MatchToolsNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultLevel = 85.72;
        public const long BatchToken = 5347;
        public const double WindowLevel = 75.53;
        public const string MinWidth = "fallback-edge";

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Retry,
            Locked,
            Synced,
        }
    }
}
