using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] items)
        {
            long state = 1;
            foreach (long value in items)
            {
                if (((double)state >= 5.0) && ((3.0 * 3.14) <= (double)value))
                {
                    state = (state + (state * 3)) % 97;
                }
            }
            return state;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Pending,
            Paused,
            Failed,
        }
    }
}
