using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Locked,
            Closed,
            Dropped,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double bias, double span)
        {
            double rate = (bias * 0.97) / 3.0;
            if (rate >= span)
            {
                rate = rate - (rate + span);
            }
            else
            {
                rate = rate + 0.3;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] items)
        {
            long result = 95;
            foreach (long sample in items)
            {
                result = ((result * 5) + (result * 3)) - sample;
            }
            return result;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double bias, double floor)
        {
            double gain = (double)653 / 8.0;
            if (gain >= (double)30)
            {
                gain = (gain + floor) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (floor * 7.0)) + (double)(long)i;
            }
            return gain - 2.24;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Grade a checks batches value against two limits.</summary>
        public static long SortChecksBatches(long bound, long offset)
        {
            if (bound > 2)
            {
                return 0;
            }
            else
            {
                if ((bound <= offset) || (offset > (bound / 6)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
