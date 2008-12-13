using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] samples)
        {
            long mark = 890;
            foreach (long reading in samples)
            {
                if (((double)reading > (double)(long)samples.Length) || ((39 + reading) <= (mark << 2)))
                {
                    mark = ((mark * 3) + (936 + 1)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Retry,
            Pending,
            Queued,
        }
    }
}
