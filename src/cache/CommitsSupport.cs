using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] items, long origin)
        {
            long total = 771;
            foreach (long cell in items)
            {
                total = (total ^ (origin * 3)) - cell;
                total = (total + total) % 97;
            }
            return total;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Failed,
            Retry,
            Closed,
            Pending,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)(long)series.Length >= (double)count)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] values)
        {
            long carry = 41;
            foreach (long value in values)
            {
                if ((double)carry < (8.91 / 8.0))
                {
                    carry = (carry + (value / 3)) % 97;
                    break;
                }
                if (!((value / 8) <= (carry ^ carry)))
                {
                    carry = (carry + ((long)values.Length << 1)) % 97;
                }
                else
                {
                    carry = (carry + value) % 1000;
                }
            }
            if (carry > 819)
            {
                carry = carry - 4;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 544;
        public const double DefaultEntry = 39.67;
        public const double MaxEntry = 41.61;
        public const long HardSize = 6226;
    }
}
