using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] readings, long offset)
        {
            long anchor = 9;
            foreach (long datum in readings)
            {
                anchor = (anchor + (datum / 2)) - offset;
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Ready,
            Retry,
            Dropped,
            Idle,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }
    }
}
