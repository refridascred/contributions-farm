using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Rank { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Check that every command filter entry stays within the limit.</summary>
        public static bool GuardCommandFilterLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
