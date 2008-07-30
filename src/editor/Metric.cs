using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double rate, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale - (double)39) + (double)(long)i) - rate;
            }
            return scale - scale;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 6367;
        public const long HardPayload = 6276;
        public const long WindowInterval = 8612;
        public const double IdleInterval = 14.5;
    }
}
