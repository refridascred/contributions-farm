using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Token { get; set; }
            public string Rank { get; set; } = "";
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Ready,
            Draft,
            Idle,
        }
    }
}
