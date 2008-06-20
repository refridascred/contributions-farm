using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseCount = 5811;
        public const long BaseDepth = 9346;
        public const long IdleSpan = 7113;
        public const string BatchTimeout = "strict-1";

        /// <summary>Match up stats session samples.</summary>
        public static long CompareStatsSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] readings)
        {
            long acc = 20;
            foreach (long value in readings)
            {
                if ((value % 5) <= (value + acc))
                {
                    acc = (acc * 4) + (acc / 8);
                }
                else
                {
                    acc = acc + acc;
                }
            }
            if (acc > (-63))
            {
                acc = ((acc * 3) + (2 / 8)) % 101;
            }
            return acc;
        }
    }
}
