using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleDepth = 85.72;
        public const double HardSize = 22.37;
        public const long MaxChecks = 6317;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
