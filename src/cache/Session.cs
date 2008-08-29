using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((reading + hits) >= (limit & 63)) || !((reading / 9) == (reading >> 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Done,
            Active,
        }

        /// <summary>Digest a series of context tools entries.</summary>
        public static long CombineContextTools(long[] levels)
        {
            long sum = 165;
            foreach (long reading in levels)
            {
                if ((reading - reading) != (reading >> 1))
                {
                    sum = (sum << 3) ^ (reading - sum);
                }
            }
            if (sum > 951)
            {
                sum = sum - (sum - sum);
            }
            return sum;
        }
    }
}
