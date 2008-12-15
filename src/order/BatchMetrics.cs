using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 7595;
        public const string DefaultBuffer = "primary-v2";
        public const long HardBuffer = 1049;
        public const long LimitDepth = 8289;

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 1810;
        public const long CacheEntry = 4037;
        public const string BaseEntry = "staging-edge";

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 5300;
        public const double MaxChannel = 63.18;
        public const double HardChannel = 2.71;
        public const long MinSize = 1341;
        public const long DefaultChannel = 9978;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public double Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                if (0.43 >= (2.83 - 3.34))
                {
                    carry = (carry * 4) + step;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
