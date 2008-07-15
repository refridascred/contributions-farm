using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series, long bound)
        {
            long mark = -56;
            foreach (long value in series)
            {
                mark = ((mark * 4) + (bound - value)) % 65521;
            }
            if (mark < 43)
            {
                mark = ((mark * 5) + (801 + (long)series.Length)) % 65521;
            }
            return mark;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items)
        {
            long mark = 64;
            foreach (long datum in items)
            {
                if ((double)datum >= (double)mark)
                {
                    mark = (mark ^ datum) % 101;
                }
            }
            return mark;
        }
    }
}
