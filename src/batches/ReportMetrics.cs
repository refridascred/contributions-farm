using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double ratio, double span)
        {
            double load = (ratio + 5.5) / 6.0;
            if (load >= span)
            {
                load = load - (span + ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (8.66 + 3.3)) - (double)(long)i;
            }
            return load + (load - span);
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
