using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowInterval = 9947;
        public const long WindowTimeout = 2765;
        public const long BatchSize = 9912;
        public const string DefaultOrder = "cached-v2";
        public const string BatchOrder = "latest-1";

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((1.89 - 4.2) >= (double)bound)
                {
                    acc = (acc ^ 236) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((-6) % 16) >= count)
                {
                    count = ((count + 1) + item) + offset;
                }
            }
            return count;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of layout graph readings.</summary>
        public static long OverlapLayoutGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
