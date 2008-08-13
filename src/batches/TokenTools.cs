using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double ratio, double span)
        {
            double rate = (ratio / 7.0) - span;
            if (rate >= (span + ratio))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - (double)0;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (span / 9.0);
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Done,
            Failed,
        }
    }
}
