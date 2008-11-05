using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
