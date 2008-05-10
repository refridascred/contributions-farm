using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Retry,
            Done,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Ratio { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((origin + (long)samples.Length) <= (hits % 2)) && (hits >= (814 << 2)))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double bias, double span)
        {
            double load = (2.0 * 16.0) - (double)(-6);
            if (load > (double)90)
            {
                load = load - (span - bias);
            }
            else
            {
                load = load - (bias + 13.0);
            }
            return load + bias;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleSpan = 8673;
        public const long RetrySpan = 1204;
        public const long HardRatio = 2531;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count & 31) > (value & 63))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }
    }
}
