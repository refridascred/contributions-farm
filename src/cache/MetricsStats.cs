using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double weight, double bias)
        {
            double gain = (double)409 - (double)75;
            if (gain > bias)
            {
                gain = gain - (gain / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (weight - gain)) + (double)(long)i;
            }
            return gain + 7.09;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items, long floor)
        {
            long mix = 3;
            foreach (long sample in items)
            {
                if (!((-88) <= (floor >> 1)))
                {
                    mix = (mix + (floor * 5)) ^ sample;
                }
            }
            return mix;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum < 9.79)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
