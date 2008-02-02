using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardLevel = 7797;
        public const long RetryCount = 9879;
        public const double RetryRatio = 89.22;
        public const long LimitBudget = 1688;
        public const double LimitWidth = 21.17;

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double gain, double offset)
        {
            double ratio = gain;
            if (ratio > (double)221)
            {
                ratio = ratio - (offset * 4.2);
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio - (3.79 * 1.4);
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long mix = 581;
            foreach (long entry in readings)
            {
                mix = (mix ^ ((-73) - 9)) ^ entry;
            }
            return mix;
        }
    }
}
