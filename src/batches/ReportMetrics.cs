using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((step < (count >> 1)) && !((entry % 3) >= (432 % 16)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many channel checks samples are out of range.</summary>
        public static long TallyChannelChecksHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!(((seen + 761) < (cell + cell)) || ((4 ^ 45) != (seen % 64))))
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
    }
}
