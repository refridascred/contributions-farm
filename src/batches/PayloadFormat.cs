using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "stable";
        public const double SoftWidth = 18.13;
        public const long HardNotes = 245;
        public const double BaseNotes = 2.93;
        public const double LimitNotes = 29.44;

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleSize = 4703;
        public const long DefaultWidth = 1128;
        public const long BurstEditor = 1757;
        public const long LimitEditor = 6608;

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double weight = span * 18.0;
            if (weight >= (span - weight))
            {
                weight = weight - gain;
            }
            return weight + gain;
        }
    }
}
