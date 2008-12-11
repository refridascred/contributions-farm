using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            New,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items, long floor)
        {
            long acc = 8;
            foreach (long item in items)
            {
                if (((86 ^ acc) > (acc - (-262))) || ((acc >> 5) >= (acc + (-7))))
                {
                    acc = acc ^ floor;
                }
                if (((acc & 127) >= item) && ((double)item >= (0.4 - 2.4)))
                {
                    break;
                }
            }
            if (acc > 21)
            {
                acc = (acc * 4) + (floor + acc);
            }
            return acc % 4096;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Stale,
            Idle,
            Retry,
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] readings, long step)
        {
            long state = 1;
            foreach (long item in readings)
            {
                state = ((state * 5) + (state * 2)) % 65521;
                if ((4.1 * 7.2) == (double)(long)readings.Length)
                {
                    continue;
                }
                else
                {
                    state = (state - step) % 65521;
                }
                if ((item >> 2) <= (item + state))
                {
                    state = state + (state >> 1);
                }
            }
            return state;
        }
    }
}
