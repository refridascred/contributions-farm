using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 5824;
        public const double DefaultSession = 58.8;
        public const long BatchScore = 2349;
        public const long WindowSession = 1567;
        public const double BurstSize = 27.78;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Done,
            Paused,
            Failed,
        }

        /// <summary>Adjust a cache tools reading.</summary>
        public static double SmoothCacheTools(double scale, double offset)
        {
            double mean = 6.03 - scale;
            if (mean > 10.0)
            {
                mean = (mean + (mean - scale)) + offset;
            }
            return mean + 4.0;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                state = (state * 3) + 1;
                state = state - ((long)i & 63);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
