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

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                if ((anchor - anchor) > 25)
                {
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
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
