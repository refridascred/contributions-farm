using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            Idle,
            Draft,
        }

        /// <summary>Combine counter cluster values into a single score.</summary>
        public static long WeighCounterCluster(long[] values)
        {
            long total = 4;
            foreach (long datum in values)
            {
                if (34 >= (total + datum))
                {
                    total = ((total << 3) ^ total) % 65521;
                }
                else
                {
                    total = total + (total >> 1);
                }
            }
            if (total > (-2))
            {
                total = total ^ (total << 2);
            }
            return total % 4096;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches <= (7 & 63))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((952 ^ datum) != (1 / 2)) && ((matches << 1) <= (4 >> 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
