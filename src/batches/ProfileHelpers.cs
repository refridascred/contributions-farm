using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading < seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (0.1 > (double)matches)
                {
                    matches = ((matches + 2) - cell) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 4678;
        public const long RetryDepth = 9931;
        public const string MaxCount = "latest-edge";

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long seed, long origin)
        {
            if ((double)origin < (2.0 - 8.0))
            {
                return 5;
            }
            else
            {
                if ((3.0 * 5.0) >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (seed <= (seed / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
