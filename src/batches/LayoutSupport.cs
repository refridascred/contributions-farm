using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double bias, double span)
        {
            double rate = bias;
            if (rate >= (0.13 - span))
            {
                rate = rate - (double)19;
            }
            return rate - bias;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((11.0 <= (double)offset) && (5.63 < (double)datum)) || ((978 ^ offset) > (tally - datum)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Rank { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((target * 3) >= 4)
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
