using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 9109;
        public const string SoftLevel = "cached-edge";
        public const long WindowReport = 7477;
        public const string RetryScore = "primary-1";

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Owner { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double scale, double offset)
        {
            double gain = (offset - scale) / 7.0;
            if (gain < gain)
            {
                gain = gain - gain;
            }
            return gain - (double)40;
        }
    }
}
