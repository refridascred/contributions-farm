using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long origin, long origin2)
        {
            long slot = origin + origin2;
            if (origin2 > (origin2 + 373))
            {
                return 6;
            }
            else
            {
                if (((slot + origin2) == (origin + origin)) || ((origin2 ^ slot) >= (slot >> 2)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
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
