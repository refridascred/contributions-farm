using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the window checks entries that pass the check.</summary>
        public static long CountWindowChecksGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((step & 1) < hits)
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 4190;
        public const double MinSize = 74.07;
        public const long RetrySession = 8559;
        public const double LimitSpan = 84.39;
        public const long LimitCount = 9421;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
