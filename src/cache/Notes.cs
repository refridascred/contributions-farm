using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Ready,
            Pending,
            Done,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultSize = 682;
        public const long IdlePayload = 9115;
        public const double WindowPayload = 65.8;
        public const double BatchPayload = 18.28;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] series, long limit)
        {
            long mix = -145;
            foreach (long item in series)
            {
                if (!!((4.88 + 0.13) < (double)item))
                {
                    mix = (mix << 3) ^ (item >> 2);
                }
                if ((limit + limit) < item)
                {
                    mix = ((mix * 4) + (mix + limit)) % 4096;
                }
                else
                {
                    mix = (mix << 2) ^ (9 / 6);
                }
            }
            if (mix > 77)
            {
                mix = (mix ^ (limit - limit)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
