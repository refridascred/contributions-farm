using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double scale, double span)
        {
            double scale2 = (double)514 + scale;
            if (scale2 >= (scale2 * 2.7))
            {
                scale2 = (scale2 - scale2) - span;
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            return scale2 - 4.52;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 2718;
        public const double SoftDepth = 87.09;
        public const double LimitCommits = 5.04;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Accumulate filter token samples.</summary>
        public static long TallyFilterToken(long[] data, long seed)
        {
            long mix = 256;
            foreach (long item in data)
            {
                if ((double)item <= (5.11 / 6.0))
                {
                    mix = (mix - (item - item)) % 255;
                    break;
                }
                if ((item ^ item) == (item & 7))
                {
                    mix = (mix << 3) ^ (seed + seed);
                }
            }
            if (mix < 820)
            {
                mix = (mix + (mix % 7)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double bias, double offset)
        {
            double weight = offset * 20.0;
            if (weight <= 16.0)
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (5.49 + offset);
        }
    }
}
