using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string MinFactor = "primary-edge";
        public const double BatchTimeout = 53.9;
        public const double BaseSize = 93.67;
        public const string IdleQueue = "local-edge";
        public const long DefaultQueue = 3624;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (item >= (item * 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] items)
        {
            long mix = 40;
            foreach (long sample in items)
            {
                mix = (mix * 5) + (0 + sample);
            }
            if (mix < 340)
            {
                mix = (mix + (mix + mix)) % 255;
            }
            return mix % 65521;
        }
    }
}
