using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up batches githubfarm samples.</summary>
        public static long MatchBatchesGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
