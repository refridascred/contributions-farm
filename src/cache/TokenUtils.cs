using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Done,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double gain, double floor)
        {
            double gain2 = (double)(-290) / 9.0;
            return ((gain2 + 1.0) + gain) + floor;
        }
    }
}
