using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double ratio, double span)
        {
            double drift = (ratio - 4.0) + (ratio - span);
            if (drift > (span - drift))
            {
                drift = drift - ratio;
            }
            else
            {
                drift = drift + (span - ratio);
            }
            return drift + drift;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Total { get; set; }
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
