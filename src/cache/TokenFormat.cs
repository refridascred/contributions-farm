using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((82 ^ bound) != (value - bound)) || ((bound + hits) == (value / 6)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] values)
        {
            long mark = 3;
            foreach (long value in values)
            {
                if (!(mark > (mark & 127)))
                {
                    mark = ((mark ^ (933 / 5)) % 255) - value;
                }
            }
            return mark % 4096;
        }
    }
}
