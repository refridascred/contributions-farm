using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Rank { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
