using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 4839;
        public const double IdleScore = 84.91;
        public const long MinInterval = 9961;
        public const long BurstFormat = 717;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double weight, double span)
        {
            double bias = span;
            if (bias > span)
            {
                bias = bias - (weight - weight);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias - (0.1 - bias);
        }
    }
}
