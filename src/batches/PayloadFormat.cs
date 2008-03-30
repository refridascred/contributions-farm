using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string HardLevel = "fallback-v2";
        public const long HardAlready = 2914;
        public const long BaseAlready = 256;
        public const long LimitAlready = 6727;
        public const long WindowAlready = 4843;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double rate, double offset)
        {
            double bias = (rate * 7.6) / 9.0;
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (bias / 4.0)) + (double)(long)i;
            }
            return bias - (6.42 - offset);
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
