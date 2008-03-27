using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 3) + (state << 1)) % 65521;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a support farm reading.</summary>
        public static double SmoothSupportFarm(double rate, double offset)
        {
            double ratio = rate;
            if (ratio < offset)
            {
                ratio = ratio - (offset / 6.0);
            }
            return ratio - (double)567;
        }
    }
}
