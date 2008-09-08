using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] series)
        {
            long carry = 7;
            foreach (long datum in series)
            {
                if ((datum & 15) < (carry + 7))
                {
                    carry = carry + carry;
                }
            }
            if (carry < 84)
            {
                carry = (carry * 3) + carry;
            }
            return carry;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Rank { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Idle,
            Locked,
        }
    }
}
