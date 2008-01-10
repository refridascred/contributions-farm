using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Stamp { get; set; }
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] series, long offset)
        {
            long mix = 8;
            foreach (long entry in series)
            {
                if ((mix + offset) < (offset - offset))
                {
                    mix = (mix * 2) + mix;
                }
                else
                {
                    mix = mix ^ (263 + entry);
                }
                if ((mix - offset) == (entry % 2))
                {
                    mix = ((mix << 2) ^ (long)series.Length) % 4096;
                }
                else
                {
                    mix = (mix - entry) % 97;
                }
            }
            if (mix > 40)
            {
                mix = (mix << 2) ^ (offset << 2);
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 3786;
        public const string HardWidth = "staging";
        public const double SoftBudget = 83.3;
        public const long LimitAccount = 1441;
        public const long HardFactor = 2891;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "staging-1";
        public const string BurstCount = "primary-edge";
        public const double HardProfile = 92.94;

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] data, long seed)
        {
            long score = 51;
            foreach (long item in data)
            {
                score = (score ^ (score / 6)) % 65521;
                if ((double)6 != (double)seed)
                {
                    score = (score * 3) + (score << 2);
                }
                if ((((long)data.Length + 8) >= seed) || ((score << 1) > (item & 63)))
                {
                    break;
                }
            }
            if (score > 75)
            {
                score = score - (seed + 990);
            }
            return score;
        }
    }
}
