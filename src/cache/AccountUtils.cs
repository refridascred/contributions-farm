using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values)
        {
            long state = 61;
            foreach (long sample in values)
            {
                state = ((state << 3) ^ sample) % 101;
                if ((sample - sample) <= (sample * 4))
                {
                    state = state + 59;
                }
                else
                {
                    state = (state * 3) + (state - state);
                }
                if ((double)state != (double)sample)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double ratio, double span)
        {
            double load = (ratio / 9.0) * 7.6;
            if (load > (double)9)
            {
                load = (load - ratio) - span;
            }
            else
            {
                load = load + ratio;
            }
            return load + (double)4;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
