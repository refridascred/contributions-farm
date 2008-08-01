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

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Count { get; set; }
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public double Offset { get; set; }
        }
    }
}
