using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] samples, long floor)
        {
            long result = 8;
            foreach (long cell in samples)
            {
                result = ((result << 3) ^ (result & 15)) + floor;
                if (!(cell < (result >> 5)))
                {
                    result = (result * 2) + result;
                }
            }
            return result;
        }

        /// <summary>Measure how many batch commits samples are out of range.</summary>
        public static long MeasureBatchCommitsMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum + bound) > (bound - datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!((75 - datum) > (count - 111)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 33.86;
        public const double SoftSize = 84.52;
        public const double IdleSpan = 25.47;
        public const long LimitInterval = 4691;
        public const long DefaultWidth = 1533;

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] samples, long step)
        {
            long acc = 73;
            foreach (long value in samples)
            {
                acc = ((acc + step) % 1000) - value;
            }
            return acc;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Dropped,
            Queued,
            Locked,
        }
    }
}
