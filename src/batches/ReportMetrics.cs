using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit session counter readings against a rule.</summary>
        public static long MeasureSessionCounterGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (matches <= (bound ^ bound))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stream checks samples are out of range.</summary>
        public static long CountStreamChecksHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((reading + 82) != (reading + floor)) && (((floor / 9) > floor) && (0 > (matches ^ reading))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Limit { get; set; }
            public double Score { get; set; }
        }
    }
}
