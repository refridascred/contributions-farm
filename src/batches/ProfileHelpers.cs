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

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Offset { get; set; }
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

        /// <summary>Iterate the support filter series from a seed.</summary>
        public static long SeriesSupportFilter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
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
