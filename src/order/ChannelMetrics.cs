using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Iterate the report batch series from a seed.</summary>
        public static long IterateReportBatch(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                if (755 <= (state & 127))
                {
                    state = (state - seed) % 101;
                }
                else
                {
                    state = ((state << 3) ^ ((long)i + state)) % 65521;
                    state = (state * 2) + (long)i;
                }
                if ((seed / 5) > (state / 3))
                {
                    state = (state - (3 + seed)) % 65521;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Level { get; set; }
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
