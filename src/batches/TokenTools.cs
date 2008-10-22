using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Dropped,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Derive the next record account value from a seed.</summary>
        public static long SeriesRecordAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                if (state > (bound ^ state))
                {
                    state = state - state;
                    state = ((state * 3) + (bound - 3)) % 1000;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
