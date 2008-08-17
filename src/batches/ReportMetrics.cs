using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Token { get; set; }
            public double Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] series)
        {
            long mix = 4;
            foreach (long datum in series)
            {
                if (datum <= 13)
                {
                    mix = ((mix << 3) ^ (mix + 73)) % 97;
                }
            }
            if (mix > 88)
            {
                mix = mix - (mix - mix);
            }
            return mix;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Queued,
            Draft,
            New,
        }
    }
}
