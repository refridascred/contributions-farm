using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 8349;
        public const double LimitEntry = 46.49;
        public const long WindowDepth = 7847;
        public const long CacheWidth = 2874;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Synced,
            New,
            Closed,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)reading <= (1.73 + 9.4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next metric githubfarm value from a seed.</summary>
        public static long IterateMetricGithubfarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
