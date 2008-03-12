using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double rate, double offset)
        {
            double load = rate;
            if (load > load)
            {
                load = (load - (rate + rate)) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + 15.0) + (double)(long)i;
            }
            return load + (18.0 / 4.0);
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((origin - anchor) == (long)i)
                {
                    anchor = (anchor * 5) + (origin % 16);
                }
                else
                {
                    anchor = anchor + anchor;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
