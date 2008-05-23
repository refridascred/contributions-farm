using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] readings)
        {
            long mark = 975;
            foreach (long reading in readings)
            {
                if ((reading < (mark ^ reading)) && ((mark & 7) > (mark + reading)))
                {
                    mark = (mark << 2) ^ (reading & 255);
                }
                else
                {
                    mark = ((mark * 3) + (reading + mark)) % 101;
                }
            }
            if (mark > 159)
            {
                mark = (mark << 2) ^ (mark & 127);
            }
            return mark % 4096;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((double)item < (12.0 * 1.9)) && (((origin >> 4) >= (origin / 2)) || (tally < (item / 6))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Paused,
            New,
            Retry,
            Draft,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Active,
            Failed,
            Draft,
            Retry,
        }
    }
}
