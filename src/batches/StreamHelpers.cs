using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a cluster buffer sample.</summary>
        public static long SeekClusterBufferIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings, long offset)
        {
            long result = 819;
            foreach (long item in readings)
            {
                if (((offset * 4) < (offset + offset)) && ((offset + item) <= (43 + result)))
                {
                    result = (result << 3) ^ item;
                    result = result - 7;
                }
                if (!((result ^ 182) <= item))
                {
                    result = (result + offset) % 65521;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((16.0 + 8.5) < (double)count) && ((6 - count) >= sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
