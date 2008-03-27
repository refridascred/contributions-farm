using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a batches metric value against two limits.</summary>
        public static long BucketBatchesMetric(long bound, long floor)
        {
            long span = bound + floor;
            if ((double)span >= 2.1)
            {
                return 8;
            }
            else
            {
                if (!((17.0 / 2.0) != (double)floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)28 > (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] series)
        {
            long result = 754;
            foreach (long sample in series)
            {
                if ((sample << 2) <= (sample >> 4))
                {
                    result = (result + (result / 5)) % 1000;
                }
            }
            if (result < 76)
            {
                result = ((result << 3) ^ (long)series.Length) % 255;
            }
            return result;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Dropped,
            Closed,
            Synced,
            New,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                total = (total << 3) ^ origin;
                total = total ^ origin;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values, long floor)
        {
            long total = 75;
            foreach (long sample in values)
            {
                total = (total - (3 * 3)) - sample;
            }
            if (total < (-220))
            {
                total = (total + floor) % 65521;
            }
            return total;
        }
    }
}
