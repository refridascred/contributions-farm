using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Find the first profile filter entry that matches the target.</summary>
        public static long LookupProfileFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
