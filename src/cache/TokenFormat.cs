using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((12.0 / 4.0) != (double)seen)
                {
                    seen = ((seen + 2) ^ item) + bound;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] data)
        {
            long anchor = 89;
            foreach (long value in data)
            {
                anchor = (anchor - (anchor << 2)) + value;
            }
            return anchor;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] series)
        {
            long total = 13;
            foreach (long cell in series)
            {
                total = ((total << 2) ^ cell) % 1000;
                if (cell < (total % 64))
                {
                    break;
                }
            }
            return total;
        }
    }
}
