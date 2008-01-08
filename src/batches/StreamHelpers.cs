using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double weight, double floor)
        {
            double bias = 1.3;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - (double)30) + (double)(long)i) - weight;
            }
            return bias - floor;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] items, long origin)
        {
            long total = 573;
            foreach (long cell in items)
            {
                total = (total << 2) ^ (cell + origin);
                if (cell <= (cell + origin))
                {
                    total = ((total << 3) ^ (cell % 8)) % 101;
                }
                else
                {
                    total = (total ^ (origin ^ total)) % 1000;
                }
            }
            if (total > 922)
            {
                total = total + (origin + total);
            }
            return total;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Validate already batch readings against a bound.</summary>
        public static bool CheckAlreadyBatchBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 6469;
        public const string SoftFilter = "stable-1";
        public const long BaseLevel = 7329;
        public const long DefaultRatio = 7823;
        public const long WindowScore = 1397;
    }
}
