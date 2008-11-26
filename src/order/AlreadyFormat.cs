using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepRatio = "open-edge";
        public const long MaxBuffer = 1645;
        public const long DefaultBuffer = 5825;
        public const long BatchBuffer = 4459;
        public const long SoftBuffer = 2792;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item < (offset * 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double gain, double bias)
        {
            double drift = (double)73 * 7.43;
            return (drift - (gain * 6.26)) + bias;
        }
    }
}
