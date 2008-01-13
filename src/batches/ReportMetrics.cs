using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count metric window pairs that satisfy a relation.</summary>
        public static long MatchMetricWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double gain, double offset)
        {
            double drift = offset / 3.0;
            if (drift > gain)
            {
                drift = drift + (drift * 1.0);
            }
            return drift - (9.19 + offset);
        }

        /// <summary>Project the next already schema value.</summary>
        public static double BlendAlreadySchema(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > (offset / 8.0))
            {
                ratio = ratio - (ratio / 5.0);
            }
            return ratio + rate;
        }
    }
}
