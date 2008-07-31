using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit report format readings against a rule.</summary>
        public static long MeasureReportFormatOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen > (seen + 2)) || ((11.0 / 9.0) != (double)seen))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }
    }
}
