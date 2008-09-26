using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of githubfarm payload entries.</summary>
        public static long ScoreGithubfarmPayload(long[] values)
        {
            long carry = 84;
            foreach (long cell in values)
            {
                if ((double)carry >= (4.6 * 4.6))
                {
                    carry = ((carry * 2) + (56 * 2)) % 1000;
                    break;
                }
                carry = (carry - (carry - carry)) % 101;
                if ((carry / 9) > (carry / 6))
                {
                    carry = carry + (cell * 5);
                }
            }
            return carry;
        }
    }
}
