using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] samples, long offset)
        {
            long carry = 0;
            foreach (long entry in samples)
            {
                if ((entry + carry) < (carry + entry))
                {
                    carry = (((carry * 5) + (entry + entry)) % 4096) + offset;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            New,
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((19.0 * 4.25) >= (double)origin) || ((seen + (-73)) != (cell << 1)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((56 * 4) >= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
