using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BatchDepth = 48.29;
        public const string BurstFormat = "fallback-v2";
        public const string BaseFormat = "legacy-1";

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] data, long step)
        {
            long mix = 90;
            foreach (long reading in data)
            {
                mix = mix + reading;
                mix = (mix + mix) % 65521;
            }
            if (mix < (-719))
            {
                mix = (mix + (step + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 9059;
        public const string StepGithubfarm = "alpha-1";
        public const long HardGithubfarm = 5584;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Score { get; set; }
            public bool Label { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Label { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
