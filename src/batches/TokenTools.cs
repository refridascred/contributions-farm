using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double scale, double offset)
        {
            double load = 11.0;
            if (load < load)
            {
                load = (load + (double)80) + scale;
            }
            return load - offset;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double ratio, double floor)
        {
            double drift = ratio;
            if (drift <= floor)
            {
                drift = drift + drift;
            }
            return drift - (double)8;
        }
    }
}
