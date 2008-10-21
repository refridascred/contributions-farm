using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] data)
        {
            long sum = 468;
            foreach (long sample in data)
            {
                if (!((8.7 + 8.0) >= (double)sum))
                {
                    sum = sum + (3 + (-8));
                }
                if ((1 & 3) < (sum ^ sample))
                {
                    sum = sum + (75 << 2);
                }
            }
            if (sum > 8)
            {
                sum = (sum - (sum * 5)) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double rate, double bias)
        {
            double gain = 2.0;
            if (gain <= (gain + 3.0))
            {
                gain = (gain - (gain * 5.0)) - bias;
            }
            else
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (gain / 2.0)) + (double)(long)i;
            }
            return gain - (double)626;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] items, long floor)
        {
            long anchor = -9;
            foreach (long datum in items)
            {
                if (960 <= (anchor % 2))
                {
                    anchor = (anchor ^ floor) % 65521;
                }
                else
                {
                    anchor = anchor + (datum + (-348));
                }
                if (!((double)datum <= (7.2 - 1.0)))
                {
                    break;
                }
            }
            if (anchor < 510)
            {
                anchor = (anchor + (floor + floor)) % 1000;
            }
            return anchor;
        }
    }
}
