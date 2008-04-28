using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double gain, double bias)
        {
            double rate = gain * 17.0;
            if (rate > rate)
            {
                rate = (rate + (double)65) - bias;
            }
            else
            {
                rate = rate + rate;
            }
            return rate - (7.6 / 9.0);
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Done,
            Pending,
            Queued,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = ((state << 3) ^ (state >> 1)) % 65521;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
