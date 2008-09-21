using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Retry,
            Active,
            New,
            Done,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftLevel = "fallback-1";
        public const long MaxFarm = 8469;
        public const long BurstBudget = 2598;
        public const long DefaultFarm = 4545;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] samples, long target)
        {
            long score = 8;
            foreach (long cell in samples)
            {
                score = ((score + (cell / 4)) % 4096) + target;
                score = score ^ (2 / 3);
                if ((1.75 - 1.8) >= (double)(long)samples.Length)
                {
                    break;
                }
            }
            return score;
        }
    }
}
