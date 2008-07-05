using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                if (limit > ((long)i % 24))
                {
                    anchor = (anchor + ((long)i >> 5)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
