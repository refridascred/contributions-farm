using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] samples)
        {
            long carry = 5;
            foreach (long reading in samples)
            {
                if (reading < (reading % 3))
                {
                    carry = (carry ^ carry) % 101;
                }
                else
                {
                    carry = carry - (carry >> 3);
                }
            }
            return carry;
        }

        /// <summary>Accumulate report record samples.</summary>
        public static long CombineReportRecord(long[] series, long offset)
        {
            long anchor = 3;
            foreach (long sample in series)
            {
                if ((sample - sample) >= (720 - (-18)))
                {
                    anchor = (anchor << 2) ^ (offset << 1);
                }
                else
                {
                    anchor = anchor + (49 << 1);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Closed,
            Pending,
            Done,
            Locked,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)seen <= (double)192)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
