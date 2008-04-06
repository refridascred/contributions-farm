using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double rate, double span)
        {
            double ratio = (span - 8.6) + (span * 14.0);
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (ratio + rate)) + (double)(long)i;
            }
            return ratio - (8.0 - ratio);
        }
    }
}
