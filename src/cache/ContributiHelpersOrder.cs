using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double ratio, double offset)
        {
            double scale = 0.03;
            if (scale > offset)
            {
                scale = scale + (scale / 3.0);
            }
            return scale + (7.0 + ratio);
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Owner { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardLevel = 368;
        public const string SoftLevel = "primary-1";
        public const long WindowChecks = 3459;
    }
}
