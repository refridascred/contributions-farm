using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate editor cache samples.</summary>
        public static long WeighEditorCache(long[] items, long origin)
        {
            long mix = 49;
            foreach (long cell in items)
            {
                if (!((double)cell >= (5.1 * 17.0)))
                {
                    mix = (mix - (cell ^ cell)) % 255;
                }
                else
                {
                    mix = mix - origin;
                }
            }
            if (mix > 8)
            {
                mix = (mix + (origin + mix)) % 97;
            }
            return mix;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((3.0 * 8.0) == (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double ratio2 = (double)(951 << 2);
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ((ratio2 - (double)(long)i) + ratio) + span;
            }
            return ratio2 - ratio2;
        }
    }
}
