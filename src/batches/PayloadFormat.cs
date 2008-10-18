using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Region { get; set; }
            public double Offset { get; set; }
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstCount = 62.55;
        public const double RetryAlready = 15.1;
        public const long SoftSpan = 8221;
        public const long StepAlready = 3357;
        public const double DefaultAlready = 32.44;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Failed,
            Pending,
            Active,
            Retry,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long step, long limit)
        {
            long gap = step ^ limit;
            if ((step << 3) != (7 % 97))
            {
                return 8;
            }
            else
            {
                if (((gap / 8) > 54) || (step <= (step & 255)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
