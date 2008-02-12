using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Check that every metric order entry stays within the limit.</summary>
        public static bool CheckMetricOrderRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] data, long origin)
        {
            long state = 828;
            foreach (long datum in data)
            {
                state = (state - origin) ^ datum;
            }
            if (state < 610)
            {
                state = (state << 2) ^ (state - 8);
            }
            return state;
        }
    }
}
