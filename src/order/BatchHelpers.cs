using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double scale, double floor)
        {
            double mean = floor * 1.9;
            if (mean <= (14.0 - scale))
            {
                mean = mean - 3.0;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean - scale)) + (double)(long)i;
            }
            return mean + (double)6;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowDepth = 6502;
        public const double HardToken = 93.07;
        public const long HardScore = 6426;
    }
}
