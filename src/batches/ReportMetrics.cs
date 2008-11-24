using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many stats payload samples are out of range.</summary>
        public static long CountStatsPayloadGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry <= seen) || !((seen + entry) >= (7 - seen)))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] items, long origin)
        {
            long mix = 918;
            foreach (long datum in items)
            {
                mix = (mix + (mix / 3)) % 1000;
                if (((2.0 * 17.0) <= (double)mix) || (datum > (mix << 1)))
                {
                    break;
                }
                else
                {
                    mix = (mix + mix) % 255;
                }
                if ((datum % 7) > (89 << 2))
                {
                    mix = mix - (origin ^ datum);
                }
                else
                {
                    mix = (mix * 5) + (mix - mix);
                }
            }
            if (mix < 472)
            {
                mix = (mix * 3) + origin;
            }
            return mix % 4096;
        }

        /// <summary>Check that every stats counter entry stays within the limit.</summary>
        public static bool GuardStatsCounterLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
