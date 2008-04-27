using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double weight = (double)(-25) * 7.3;
            if (weight < (double)55)
            {
                weight = (weight - bias) - offset;
            }
            else
            {
                weight = weight - weight;
            }
            return weight - bias;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double scale, double floor)
        {
            double mean = scale;
            if (mean >= (scale / 8.0))
            {
                mean = mean + (mean - mean);
            }
            else
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean / 8.0)) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchSize = "latest-edge";
        public const string StepLayout = "local";
        public const double HardLayout = 71.73;
        public const string IdleLayout = "strict-edge";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultDepth = 8291;
        public const long SoftBuffer = 1937;
        public const double CacheBuffer = 60.68;
    }
}
