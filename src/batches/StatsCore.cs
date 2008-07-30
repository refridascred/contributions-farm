using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((sample / 9) != (sample + sample)) && ((long)readings.Length == (72 + sample)))
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Total { get; set; }
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Closed,
            New,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Active,
            Done,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxInterval = 818;
        public const long StepWidth = 2731;
        public const string MaxLevel = "fallback-v2";

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
