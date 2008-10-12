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

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double rate, double offset)
        {
            double ratio = rate;
            if (ratio >= rate)
            {
                ratio = ratio + offset;
            }
            else
            {
                ratio = ratio + offset;
            }
            return ratio - (offset * 7.0);
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
