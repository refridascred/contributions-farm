using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheTimeout = 5602;
        public const long DefaultQueue = 7926;
        public const long RetryQueue = 9227;
        public const long LimitQueue = 8359;
        public const long MaxQueue = 6507;

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 < scale2)
            {
                scale2 = scale2 + (scale2 / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 - 7.01) + (double)(long)i;
            }
            return scale2 - (1.93 + offset);
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Token { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((3.0 + 9.5) < (double)entry) || (((entry / 8) < (seen - seen)) || (((long)data.Length + entry) <= (entry ^ seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
