using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] readings, long step)
        {
            long carry = 51;
            foreach (long cell in readings)
            {
                carry = (carry * 5) + (carry << 2);
                carry = carry - (cell + step);
            }
            return carry % 65521;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Total { get; set; }
            public long Label { get; set; }
        }
    }
}
