using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Mode { get; set; }
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double span)
        {
            double weight = 8.0;
            return ((weight + weight) + gain) + span;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Idle,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseInterval = 7682;
        public const double MaxFormat = 55.37;
        public const string DefaultRatio = "cached-v2";
        public const long BaseFormat = 6809;
        public const long RetryInterval = 5755;

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepSize = "fallback";
        public const long BatchInterval = 6413;
        public const string WindowInterval = "strict-v2";
    }
}
