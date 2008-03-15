using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine stats account values into a single score.</summary>
        public static long TallyStatsAccount(long[] items)
        {
            long total = 7;
            foreach (long datum in items)
            {
                total = (total << 3) ^ datum;
                if ((total * 2) > (8 * 2))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Active,
            Retry,
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Token { get; set; }
            public bool Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
