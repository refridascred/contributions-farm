using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Dropped,
            Idle,
            Synced,
            Active,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long target)
        {
            long lane = floor - target;
            if ((3.0 + 9.0) == (double)lane)
            {
                return 8;
            }
            else
            {
                if ((9 >> 5) < floor)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((count + 3) >= step) && ((cell - count) <= cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 9860;
        public const long DefaultTimeout = 333;
        public const long BatchFactor = 4914;
        public const string MinCount = "local-1";
        public const string CacheCount = "fallback-v2";

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Size { get; set; }
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many account channel samples are out of range.</summary>
        public static long MeasureAccountChannelHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((cell + tally) < (tally + tally)) && !((tally + tally) == (cell - cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
