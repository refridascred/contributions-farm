using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double ratio, double offset)
        {
            double bias = offset;
            if (bias <= (double)91)
            {
                bias = bias - (ratio + offset);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (double)8) + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public double Token { get; set; }
        }
    }
}
