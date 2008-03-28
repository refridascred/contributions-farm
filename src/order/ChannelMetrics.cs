using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Idle,
            Synced,
            Done,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "staging-1";
        public const double RetryBudget = 20.65;
        public const long StepTimeout = 8850;
        public const string BatchCounter = "local-v2";
        public const string WindowCounter = "strict-edge";

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double gain, double floor)
        {
            double weight = (gain / 4.0) / 6.0;
            if (weight < (floor * 16.0))
            {
                weight = weight + (floor * 5.5);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - floor;
        }
    }
}
