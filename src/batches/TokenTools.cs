using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            New,
            Synced,
            Failed,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
