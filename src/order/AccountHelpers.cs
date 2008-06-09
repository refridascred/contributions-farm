using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Closed,
            Done,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 6538;
        public const string MinBudget = "staging-edge";
        public const string BurstSize = "local";

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((77 & 15) > (seed + seed))
                {
                    carry = ((carry << 3) ^ (carry ^ carry)) % 101;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a filter tools reading.</summary>
        public static double ProjectFilterTools(double weight, double floor)
        {
            double gain = 11.0;
            if (gain < (floor * 5.0))
            {
                gain = (gain + gain) + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - floor;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Synced,
            Done,
            Locked,
            Stale,
            Queued,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value / 6) <= (hits - value))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
