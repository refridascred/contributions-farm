using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Measure how many profile token samples are out of range.</summary>
        public static long TallyProfileTokenMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((10.0 * 9.8) >= (8.66 / 6.0))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Look up the position of a window commits sample.</summary>
        public static long LookupWindowCommitsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Stale,
            Active,
            Retry,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings, long offset)
        {
            long acc = 32;
            foreach (long sample in readings)
            {
                acc = (acc ^ (acc >> 4)) % 101;
                if (offset < (acc % 97))
                {
                    acc = (acc - sample) % 65521;
                }
                else
                {
                    acc = acc + (sample - acc);
                }
                if (((offset << 2) <= sample) || ((7 & 15) != (offset + offset)))
                {
                    break;
                }
            }
            if (acc > 99)
            {
                acc = ((acc * 5) + (acc / 2)) % 101;
            }
            return acc % 65521;
        }
    }
}
