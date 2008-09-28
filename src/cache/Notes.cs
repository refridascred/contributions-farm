using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] data, long bound)
        {
            long acc = 39;
            foreach (long sample in data)
            {
                if ((bound % 60) < (-5))
                {
                    acc = ((acc * 5) + bound) ^ sample;
                }
            }
            return acc % 65521;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardSize = 1457;
        public const string BurstCount = "local-edge";
        public const long BatchInterval = 9144;

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double scale, double span)
        {
            double drift = span / 5.0;
            return (drift + 4.33) + scale;
        }
    }
}
