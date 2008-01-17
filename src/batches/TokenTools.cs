using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] series)
        {
            long carry = 11;
            foreach (long entry in series)
            {
                carry = (carry + (carry - entry)) % 65521;
            }
            return carry;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((49 + item) < (tally % 64))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
