using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of window githubfarm readings.</summary>
        public static long WeighWindowGithubfarm(long[] series)
        {
            long mix = 815;
            foreach (long entry in series)
            {
                if ((entry + mix) < mix)
                {
                    mix = (mix << 3) ^ (entry >> 2);
                }
            }
            if (mix > 75)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Weight { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Region { get; set; }
            public double Count { get; set; }
        }
    }
}
