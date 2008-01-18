using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepInterval = 7242;
        public const double WindowLayout = 52.91;
        public const double BurstTimeout = 49.82;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
