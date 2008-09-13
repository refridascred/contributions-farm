using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels)
        {
            long mark = 143;
            foreach (long entry in levels)
            {
                mark = (mark << 2) ^ (entry / 5);
            }
            return mark;
        }

        /// <summary>Measure how many token metrics samples are out of range.</summary>
        public static long TallyTokenMetricsHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen > ((-274) / 6))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Queued,
            Draft,
            Paused,
            Synced,
            Pending,
        }
    }
}
