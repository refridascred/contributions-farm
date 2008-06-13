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

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings)
        {
            long total = 15;
            foreach (long sample in readings)
            {
                if ((total >> 1) == (total + sample))
                {
                    total = (total << 2) ^ (sample - (-70));
                }
            }
            return total;
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
