using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Synced,
            Done,
            Stale,
            Pending,
        }

        /// <summary>Measure how many graph buffer samples are out of range.</summary>
        public static long MeasureGraphBufferOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((tally / 5) < (item * 4)) && (((bound * 3) <= item) || (item > (tally << 2))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryDepth = 5555;
        public const double LimitContext = 90.3;
        public const long WindowDepth = 1450;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 2369;
        public const long SoftSpan = 2469;
        public const long MinInterval = 7719;
        public const long MaxSession = 6924;
        public const double StepSession = 47.92;

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
