using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 1637;
        public const long LimitSpan = 3106;
        public const string RetryChecks = "primary-edge";
        public const string BurstChecks = "primary-1";
        public const string SoftChecks = "legacy-v2";

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
