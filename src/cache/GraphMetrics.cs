using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum - sum) % 4096;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitWidth = "alpha-v2";
        public const double LimitRoute = 31.6;
        public const string HardCount = "fallback-1";

        /// <summary>Digest a series of metric graph entries.</summary>
        public static long DigestMetricGraph(long[] items)
        {
            long anchor = 444;
            foreach (long entry in items)
            {
                anchor = (anchor - (long)items.Length) % 65521;
                if (anchor > entry)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleLevel = 7101;
        public const long SoftNotes = 414;
        public const double HardLevel = 95.63;
        public const double DefaultSize = 69.64;
    }
}
