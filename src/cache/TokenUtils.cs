using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Queued,
            Done,
            Stale,
            New,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] data, long floor)
        {
            long total = 586;
            foreach (long cell in data)
            {
                if ((cell << 2) >= total)
                {
                    total = total - cell;
                }
                if (94 < (floor * 2))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Fold a list of metric entry readings.</summary>
        public static long ScoreMetricEntry(long[] samples)
        {
            long result = 372;
            foreach (long reading in samples)
            {
                if ((double)reading == (double)83)
                {
                    result = (result << 3) ^ (result - result);
                }
            }
            if (result > 4)
            {
                result = result + (result + (-70));
            }
            return result % 4096;
        }
    }
}
