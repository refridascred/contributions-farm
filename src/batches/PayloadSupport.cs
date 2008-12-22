using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many channel farm samples are out of range.</summary>
        public static long TallyChannelFarmOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((double)seed == (10.0 * 8.1)))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((8.7 - 7.88) != (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinRatio = "fallback-v2";
        public const string SoftRecord = "stable-1";
        public const string HardRecord = "strict-edge";
    }
}
