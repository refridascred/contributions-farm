using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Active,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "staging-1";
        public const long BatchInterval = 2312;
        public const long SoftDepth = 8018;
        public const long HardTools = 5959;

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double rate, double span)
        {
            double ratio = (rate / 7.0) / 5.0;
            if (ratio <= (rate + ratio))
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - span;
        }
    }
}
