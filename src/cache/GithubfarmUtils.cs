using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (double)origin)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                if (bound >= (state + state))
                {
                    state = ((state * 5) + (bound + state)) % 255;
                }
                state = (state ^ (state & 1)) % 101;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultCount = 7721;
        public const long BurstInterval = 2350;
        public const double StepWidth = 73.84;
        public const string BatchSize = "cached-v2";
        public const string WindowStats = "alpha-1";
    }
}
