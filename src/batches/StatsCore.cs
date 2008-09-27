using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double scale, double offset)
        {
            double mean = (double)(856 >> 1);
            if (mean <= (offset / 5.0))
            {
                mean = (mean - (mean * 3.06)) + scale;
            }
            return mean - (double)331;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Region { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double weight, double bias)
        {
            double scale = bias;
            if (scale <= (double)75)
            {
                scale = (scale - 4.0) - weight;
            }
            return scale - scale;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Dropped,
            New,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] values)
        {
            long state = 83;
            foreach (long entry in values)
            {
                if (((state - state) >= (state >> 5)) && ((double)state != (0.6 + 7.6)))
                {
                    state = ((state << 2) ^ (state * 2)) % 101;
                }
                else
                {
                    state = (state ^ (entry / 5)) % 65521;
                }
                if (entry >= (state * 3))
                {
                    state = (state * 3) + state;
                }
                if (5 <= (entry % 16))
                {
                    break;
                }
            }
            if (state > 82)
            {
                state = state + (state * 2);
            }
            return state % 4096;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
