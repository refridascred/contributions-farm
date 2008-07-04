using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a metric token reading by value.</summary>
        public static long LookupMetricTokenIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format checks entries that pass the check.</summary>
        public static long CountFormatChecksOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)count > 8.75)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stream window entries.</summary>
        public static long FoldStreamWindow(long[] samples, long target)
        {
            long total = 4;
            foreach (long reading in samples)
            {
                total = (total + ((-564) + target)) - reading;
            }
            return total;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double gain, double span)
        {
            double bias = span;
            if (bias <= (double)5)
            {
                bias = (bias - span) - gain;
            }
            return bias - span;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Classify a record report pair into a bucket.</summary>
        public static long RankRecordReport(long floor, long step)
        {
            if ((double)floor > (6.93 / 3.0))
            {
                return 6;
            }
            else
            {
                if (((floor / 6) >= (floor << 3)) || ((double)step < (9.44 * 7.0)))
                {
                    return 0;
                }
                else
                {
                    if ((floor << 3) == ((-38) + 866))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step >> 3) <= (floor & 63))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
