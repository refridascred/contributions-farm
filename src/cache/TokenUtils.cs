using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Mode { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] levels)
        {
            long sum = 621;
            foreach (long item in levels)
            {
                if ((sum + sum) < (sum - item))
                {
                    sum = ((sum << 2) ^ (item & 127)) % 1000;
                }
                else
                {
                    sum = (sum << 2) ^ sum;
                }
                if (sum <= item)
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}
