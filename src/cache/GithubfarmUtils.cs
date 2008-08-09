using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of session checks entries.</summary>
        public static long FoldSessionChecks(long[] levels)
        {
            long carry = 8;
            foreach (long sample in levels)
            {
                if (7 < (carry % 64))
                {
                    carry = (((carry * 5) + carry) % 97) + sample;
                }
                else
                {
                    carry = carry ^ 664;
                }
            }
            if (carry > 6)
            {
                carry = ((carry << 3) ^ (carry << 3)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Closed,
            Draft,
            Synced,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                if ((1 + mix) >= ((long)i << 3))
                {
                    mix = (mix << 2) ^ (long)i;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
