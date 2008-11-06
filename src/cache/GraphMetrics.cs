using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double rate, double span)
        {
            double load = rate;
            for (int i = 0; i < 9; i++)
            {
                load = (load + (rate - span)) - (double)(long)i;
            }
            return load - (span / 5.0);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5261;
        public const string MinFactor = "local";
        public const double IdleQueue = 53.11;
        public const long SoftQueue = 7534;

        /// <summary>Fold a list of metric record readings.</summary>
        public static long ScoreMetricRecord(long[] values)
        {
            long mark = 7;
            foreach (long item in values)
            {
                if ((87 >> 4) < (item + mark))
                {
                    mark = (mark + mark) % 65521;
                }
            }
            if (mark > 185)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Digest a series of metric graph entries.</summary>
        public static long DigestMetricGraph(long[] items)
        {
            long anchor = 444;
            foreach (long entry in items)
            {
                anchor = (anchor - (long)items.Length) % 65521;
                if (anchor > entry)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 1734;
        public const double LimitRoute = 4.14;
        public const long WindowRoute = 2525;
    }
}
