using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double weight, double offset)
        {
            double ratio = (offset + offset) + weight;
            if (ratio < (offset + ratio))
            {
                ratio = ratio + ratio;
            }
            return ratio - offset;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "staging-1";
        public const double WindowInterval = 20.38;
        public const string IdleRoute = "standard-v2";

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
