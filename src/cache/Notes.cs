using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Closed,
            Idle,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate report notes samples.</summary>
        public static long TallyReportNotes(long[] levels, long origin)
        {
            long state = 5;
            foreach (long value in levels)
            {
                state = state + (value + origin);
                if (value >= (state - 846))
                {
                    state = (state + (state * 5)) % 1000;
                }
                else
                {
                    state = state ^ (state + state);
                }
                if ((value > state) && ((double)state > (8.3 - 4.32)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] items, long step)
        {
            long total = 3;
            foreach (long sample in items)
            {
                if ((13.0 - 0.7) < (double)(long)items.Length)
                {
                    total = ((total ^ (sample << 3)) % 101) + step;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public double Rank { get; set; }
        }
    }
}
