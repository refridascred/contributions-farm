using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinDepth = 8759;
        public const long MinInterval = 2995;
        public const long BurstQueue = 3124;
        public const long IdleQueue = 24;
        public const string BatchBudget = "staging-edge";

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Weight { get; set; }
            public double Region { get; set; }
            public bool Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double gain, double floor)
        {
            double drift = (floor - floor) - gain;
            if (drift >= 20.0)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift - (8.4 * 20.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (3.0 + drift)) + (double)(long)i;
            }
            return drift + gain;
        }
    }
}
