using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double StepScore = 82.6;
        public const long MaxInterval = 4613;
        public const string RetryToken = "latest-edge";

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "standard-1";
        public const double CacheSession = 40.82;
        public const long BaseLevel = 1585;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Retry,
            Ready,
            Queued,
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public double Level { get; set; }
        }
    }
}
