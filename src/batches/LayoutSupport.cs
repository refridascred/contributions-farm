using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 93.44;
        public const string BatchLevel = "open";
        public const double StepDepth = 96.77;
        public const double LimitWidth = 5.01;
        public const long IdleContributi = 2068;

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Score { get; set; } = "";
            public bool Size { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = state - (seed * 2);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double bias)
        {
            double mean = ratio;
            return mean + bias;
        }
    }
}
