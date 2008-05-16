using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] series)
        {
            long carry = 92;
            foreach (long reading in series)
            {
                if ((reading + reading) < carry)
                {
                    carry = carry ^ reading;
                }
            }
            if (carry < 78)
            {
                carry = (carry - (carry ^ carry)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)target == (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
