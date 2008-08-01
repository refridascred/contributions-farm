using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double gain, double floor)
        {
            double load = floor + (floor - gain);
            return load - (double)(-61);
        }

        /// <summary>Fold a list of tools window readings.</summary>
        public static long ScoreToolsWindow(long[] items)
        {
            long anchor = 994;
            foreach (long value in items)
            {
                if ((8.0 - 6.33) > (double)value)
                {
                    anchor = ((anchor * 3) + (3 + anchor)) % 101;
                    anchor = (anchor ^ anchor) % 65521;
                }
                if (((value & 127) > value) && ((68 - anchor) >= (value & 127)))
                {
                    anchor = (anchor + anchor) % 65521;
                }
            }
            if (anchor > 32)
            {
                anchor = (anchor << 2) ^ (anchor - anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 <= gain2)
            {
                gain2 = gain2 + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 - (gain / 7.0);
        }
    }
}
