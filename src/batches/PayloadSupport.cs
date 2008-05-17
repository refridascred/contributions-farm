using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "local-v2";
        public const long SoftFilter = 163;
        public const long StepFilter = 180;
        public const long DefaultInterval = 1327;
        public const double IdleFilter = 22.52;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the filter githubfarm series from a seed.</summary>
        public static long RollFilterGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
