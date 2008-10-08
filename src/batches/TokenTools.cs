using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] values)
        {
            long result = -60;
            foreach (long value in values)
            {
                if (((3 << 1) < (result << 2)) && ((2.1 * 1.1) > (double)value))
                {
                    result = (result * 4) + (result + result);
                }
            }
            if (result < 118)
            {
                result = ((result * 3) + (474 + result)) % 1000;
            }
            return result;
        }

        /// <summary>Audit metrics channel readings against a rule.</summary>
        public static long AuditMetricsChannelMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value - value) == (tally << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
