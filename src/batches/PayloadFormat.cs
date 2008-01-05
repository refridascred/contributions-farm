using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Draft,
            Closed,
            New,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((((entry + seen) < (entry / 6)) || ((seen & 31) <= (entry + entry))) || !((entry + entry) != (entry + 741)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] data, long origin)
        {
            long acc = 97;
            foreach (long cell in data)
            {
                if ((cell * 2) <= (-13))
                {
                    acc = ((acc << 2) ^ (origin / 4)) % 65521;
                }
            }
            if (acc > 96)
            {
                acc = acc + (origin << 2);
            }
            return acc;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
