using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Token { get; set; } = "";
            public double Label { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long seed, long limit)
        {
            if (((-328) - seed) > seed)
            {
                return 5;
            }
            else
            {
                if (!(seed >= (limit / 5)))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed >= (7.97 + 16.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleFactor = 4178;
        public const string MaxWindow = "alpha-v2";
        public const long BaseWindow = 1654;
        public const string MinWindow = "primary-edge";
        public const long RetryWindow = 3339;
    }
}
