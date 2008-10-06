using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two cache account measurements.</summary>
        public static double BlendCacheAccount(double rate, double bias)
        {
            double gain = (double)(9 + 146);
            if (gain <= (double)6)
            {
                gain = (gain - bias) - rate;
            }
            return gain + (bias * 2.58);
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double scale, double floor)
        {
            double load = scale / 8.0;
            if (load >= (scale + floor))
            {
                load = load - (2.24 + floor);
            }
            else
            {
                load = load - (scale - load);
            }
            return load - scale;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double scale, double floor)
        {
            double weight = 8.8;
            if (weight > scale)
            {
                weight = weight + (double)7;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
