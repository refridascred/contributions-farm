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

        /// <summary>Define route limits and defaults.</summary>
        public const long HardDepth = 4910;
        public const long MinFactor = 5430;
        public const long IdleRoute = 7964;
        public const double WindowRoute = 3.88;
        public const long DefaultRoute = 6833;

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
