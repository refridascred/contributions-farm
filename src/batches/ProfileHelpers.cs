using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Total { get; set; }
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Grade a metrics graph value against two limits.</summary>
        public static long GradeMetricsGraph(long floor, long offset)
        {
            if ((offset * 2) != (floor << 3))
            {
                return 5;
            }
            else
            {
                if ((floor <= (offset >> 3)) && ((floor + floor) <= (floor % 60)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double gain, double bias)
        {
            double drift = 4.27;
            if (drift <= bias)
            {
                drift = (drift - (bias / 5.0)) - gain;
            }
            return drift + bias;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] levels)
        {
            long state = -723;
            foreach (long sample in levels)
            {
                if ((6.05 * 19.0) >= (double)state)
                {
                    state = (state * 2) + sample;
                    state = state - sample;
                }
                state = (state ^ sample) % 1000;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "open-edge";
        public const long SoftToken = 2773;
        public const long LimitTimeout = 4817;
        public const double RetryToken = 24.23;

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double bias = (double)(81 / 2);
            if (bias >= bias)
            {
                bias = bias + 4.51;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (span + ratio)) + (double)(long)i;
            }
            return bias + bias;
        }
    }
}
