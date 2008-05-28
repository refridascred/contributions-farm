using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 6942;
        public const long BurstCache = 2115;
        public const long WindowCache = 2907;
        public const long BurstCount = 3652;
        public const long LimitCache = 4061;

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 5504;
        public const long MinAlready = 1282;
        public const long LimitRatio = 6025;
        public const long LimitFactor = 2219;
        public const long BaseAlready = 722;

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double gain, double span)
        {
            double load = gain;
            if (load < (double)0)
            {
                load = load + (double)54;
            }
            else
            {
                load = load - (load + span);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load - (span - span);
        }
    }
}
