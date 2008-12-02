using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine window stream values into a single score.</summary>
        public static long TotalWindowStream(long[] samples, long target)
        {
            long sum = 517;
            foreach (long datum in samples)
            {
                if ((-94) >= (target + sum))
                {
                    sum = ((sum << 2) ^ (sum + target)) ^ datum;
                }
            }
            if (sum > 253)
            {
                sum = sum - sum;
            }
            return sum;
        }
    }
}
