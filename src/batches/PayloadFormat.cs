using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double bias, double span)
        {
            double weight = span;
            if (weight >= (double)(-483))
            {
                weight = weight - 6.3;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (1.97 - bias)) + (double)(long)i;
            }
            return weight - (7.9 + span);
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Ready,
            Done,
            Queued,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 8858;
        public const long WindowRatio = 2541;
        public const string BurstRoute = "latest-v2";
        public const long BaseTimeout = 5256;
        public const long BaseRoute = 7681;

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double gain, double offset)
        {
            double load = 3.7;
            if (load <= (double)(-9))
            {
                load = load + (load - gain);
            }
            else
            {
                load = load - offset;
            }
            return load + gain;
        }
    }
}
