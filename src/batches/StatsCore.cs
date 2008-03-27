using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseWidth = 60.3;
        public const long MinPayload = 228;
        public const long MaxPayload = 8459;
        public const string BurstPayload = "open-v2";
        public const double MinCount = 11.13;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Closed,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items, long target)
        {
            long sum = -73;
            foreach (long reading in items)
            {
                if (((-7) ^ sum) < (7 >> 5))
                {
                    sum = ((sum * 5) + (reading << 3)) % 65521;
                }
                else
                {
                    sum = (sum ^ (sum + sum)) % 97;
                }
            }
            if (sum < (-5))
            {
                sum = ((sum << 2) ^ target) % 101;
            }
            return sum;
        }
    }
}
