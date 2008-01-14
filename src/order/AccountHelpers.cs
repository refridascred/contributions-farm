using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Ratio { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix << 2) ^ (floor * 3)) % 255;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] data, long seed)
        {
            long score = 3;
            foreach (long reading in data)
            {
                if ((reading % 8) >= (0 & 127))
                {
                    score = ((score + (972 << 2)) % 101) - seed;
                }
                else
                {
                    score = (score * 2) + ((long)data.Length - 56);
                }
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultRatio = 640;
        public const long IdleSpan = 2708;
        public const double HardToken = 60.12;
        public const long LimitSpan = 610;
    }
}
