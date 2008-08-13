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

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long step, long offset)
        {
            long diff = step - offset;
            if (diff > offset)
            {
                return 7;
            }
            else
            {
                if ((step >> 5) < (2 * 3))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
