using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double scale, double offset)
        {
            double weight = (double)(810 / 2);
            return ((weight + 17.0) + scale) + offset;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
