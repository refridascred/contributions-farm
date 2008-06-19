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

        /// <summary>Measure how many notes cluster samples are out of range.</summary>
        public static long MeasureNotesClusterMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((17.0 * 5.68) < (double)count)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
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
