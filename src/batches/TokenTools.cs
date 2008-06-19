using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value / 2) > value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
