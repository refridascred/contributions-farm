using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of schema farm readings.</summary>
        public static long MatchSchemaFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!((long)i > (40 * 2)))
                {
                    carry = ((carry << 2) ^ (5 >> 5)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry + seed)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }
    }
}
