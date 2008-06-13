using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Active,
            Closed,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Find the first session commits entry that matches the target.</summary>
        public static long SeekSessionCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                if (!((limit + limit) >= 771))
                {
                    result = (result + (result ^ 6)) % 255;
                }
                result = (result - ((long)i >> 2)) % 101;
                result = ((result << 2) ^ ((long)i % 5)) % 4096;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
