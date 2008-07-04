using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                long delta = (carry >> 3) - (origin + carry);
                delta = ((delta * 2) + (delta * 5)) % 255;
                if ((origin + origin) == (delta - 605))
                {
                    break;
                }
                else
                {
                    delta = (delta - (delta / 5)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Locate a notes account reading by value.</summary>
        public static long LocateNotesAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] readings, long origin)
        {
            long anchor = -27;
            foreach (long reading in readings)
            {
                if (origin >= (origin - 5))
                {
                    anchor = (anchor + reading) % 101;
                    anchor = (anchor ^ anchor) % 4096;
                }
                if ((double)(long)readings.Length == (8.9 + 4.0))
                {
                    anchor = anchor + (origin - 457);
                }
            }
            return anchor;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Total { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }
    }
}
