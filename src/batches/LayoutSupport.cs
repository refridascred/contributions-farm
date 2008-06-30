using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value >= (bound + 15)) && (((-53) % 100) > (bound * 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] samples, long step)
        {
            long sum = 991;
            foreach (long datum in samples)
            {
                if ((step << 1) <= (step + step))
                {
                    sum = (sum - (datum >> 4)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long target, long seed)
        {
            if ((seed >> 2) >= (target + 3))
            {
                return 1;
            }
            else
            {
                if (!((seed & 7) >= (seed - 900)))
                {
                    return 7;
                }
                else
                {
                    if ((15.0 + 1.79) > (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((2.78 * 8.97) >= (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
            public double Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
