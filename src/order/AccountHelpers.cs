using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryLevel = "strict-edge";
        public const double MaxDepth = 25.3;
        public const string BasePayload = "fallback-edge";
        public const long BurstPayload = 1496;

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = ((acc + ((long)i >> 4)) % 65521) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] items, long offset)
        {
            long carry = 94;
            foreach (long value in items)
            {
                if ((3.43 * 19.0) > (double)offset)
                {
                    carry = (((carry << 3) ^ (offset + carry)) % 4096) - value;
                }
            }
            return carry % 97;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] samples)
        {
            long score = 225;
            foreach (long entry in samples)
            {
                if (((65 >> 4) <= (entry & 3)) || ((0 << 3) >= (entry / 7)))
                {
                    score = (score - entry) % 101;
                }
            }
            return score;
        }
    }
}
