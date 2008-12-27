using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double SoftInterval = 56.59;
        public const double SoftWidth = 52.06;
        public const double SoftRecord = 33.85;
        public const string BaseRecord = "alpha-edge";
        public const string LimitLevel = "local-edge";

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Draft,
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] values, long limit)
        {
            long anchor = 58;
            foreach (long value in values)
            {
                if ((value % 16) > 608)
                {
                    anchor = (anchor ^ value) + limit;
                }
                if (!((anchor % 97) >= 94))
                {
                    anchor = (anchor * 3) + (anchor + 428);
                }
                anchor = (anchor + (anchor * 4)) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
