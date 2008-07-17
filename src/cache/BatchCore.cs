using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double bias, double span)
        {
            double mean = (bias - bias) / 8.0;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - bias) - (double)(long)i) - span;
            }
            return mean - bias;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long origin, long origin2)
        {
            long delta = origin + origin2;
            if ((delta / 8) > origin2)
            {
                return 5;
            }
            else
            {
                if ((origin2 / 4) > (origin % 100))
                {
                    return 2;
                }
                else
                {
                    if (origin2 >= (delta * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum >= (datum * 5)) || (((datum % 24) >= (5 - 434)) && ((datum % 3) < (datum << 1))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
