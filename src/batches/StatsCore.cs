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

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
