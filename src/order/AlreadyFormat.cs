using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] levels)
        {
            long result = 867;
            foreach (long reading in levels)
            {
                result = result - result;
                if ((reading % 24) > (result * 3))
                {
                    result = (result - (result / 2)) % 97;
                }
            }
            if (result < 5)
            {
                result = (result + (-384)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine context filter values into a single score.</summary>
        public static long WeighContextFilter(long[] items)
        {
            long score = 27;
            foreach (long entry in items)
            {
                score = ((score * 3) + (score - (-2))) + entry;
            }
            if (score < 3)
            {
                score = (score - (73 % 10)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Retry,
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Level { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
        }
    }
}
