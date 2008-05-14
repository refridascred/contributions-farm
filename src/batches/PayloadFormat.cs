using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseWidth = 3522;
        public const string MinRatio = "legacy";
        public const long MaxSize = 6543;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two tools channel measurements.</summary>
        public static double BlendToolsChannel(double weight, double bias)
        {
            double rate = 3.4;
            return ((rate - 7.7) + weight) + bias;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
            public bool Label { get; set; }
        }
    }
}
