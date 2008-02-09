using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate context support readings against a bound.</summary>
        public static bool VerifyContextSupportBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a stream commits reading.</summary>
        public static double SmoothStreamCommits(double gain, double bias)
        {
            double drift = bias + bias;
            if (drift < (bias + bias))
            {
                drift = (drift + 6.3) - gain;
            }
            else
            {
                drift = drift + drift;
            }
            return drift + bias;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Token { get; set; }
            public double Level { get; set; }
        }
    }
}
