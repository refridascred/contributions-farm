using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (6.0 < (double)hits)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Ratio { get; set; }
            public double Size { get; set; }
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next commits session value from a seed.</summary>
        public static long DeriveCommitsSession(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine queue route values into a single score.</summary>
        public static long WeighQueueRoute(long[] samples)
        {
            long carry = 0;
            foreach (long value in samples)
            {
                if (value > (value % 12))
                {
                    carry = carry + (value & 7);
                }
            }
            if (carry < 984)
            {
                carry = carry - (carry & 31);
            }
            return carry % 97;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Count the order cluster entries that pass the check.</summary>
        public static long CountOrderClusterOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((9 % 7) < ((-99) - step))
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
