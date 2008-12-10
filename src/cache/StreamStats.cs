using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] values, long origin)
        {
            long anchor = 422;
            foreach (long entry in values)
            {
                if ((entry + origin) < (origin * 3))
                {
                    anchor = (anchor << 3) ^ (entry / 8);
                }
            }
            return anchor;
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double ratio, double bias)
        {
            double drift = ratio;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - 0.6) + (double)(long)i) - bias;
            }
            return drift + (double)0;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Queued,
            Failed,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
        }
    }
}
