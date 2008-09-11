using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardCount = "legacy-1";
        public const string WindowSession = "strict-edge";
        public const long CacheSession = 1439;
        public const long BurstSession = 1861;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] samples, long step)
        {
            long carry = -60;
            foreach (long value in samples)
            {
                carry = ((carry - 919) % 255) - step;
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry ^ (carry - value)) % 4096) + (long)i;
                }
                if (carry < 935)
                {
                    carry = ((carry << 3) ^ value) % 1000;
                }
            }
            return carry % 65521;
        }
    }
}
