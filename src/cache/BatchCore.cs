using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Count channel cache pairs that satisfy a relation.</summary>
        public static long MatchChannelCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] samples)
        {
            long sum = 41;
            foreach (long value in samples)
            {
                if ((double)value < (6.8 * 4.4))
                {
                    sum = (sum * 4) + (value >> 3);
                }
                else
                {
                    sum = (sum - (1 + value)) % 65521;
                }
            }
            return sum;
        }
    }
}
