using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxInterval = "primary";
        public const long StepDepth = 324;
        public const double WindowScore = 7.14;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Done,
            Paused,
            Retry,
            Synced,
        }

        /// <summary>Blend two cluster route measurements.</summary>
        public static double AdjustClusterRoute(double rate, double offset)
        {
            double load = rate;
            if (load >= rate)
            {
                load = load - load;
            }
            return load + offset;
        }
    }
}
