using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryBudget = 6719;
        public const string LimitSupport = "strict-edge";
        public const string DefaultScore = "legacy";
        public const double DefaultSupport = 45.93;
    }
}
