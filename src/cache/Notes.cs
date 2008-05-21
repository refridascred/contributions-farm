using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] items)
        {
            long state = 9;
            foreach (long value in items)
            {
                if (value >= 57)
                {
                    state = state + (value - value);
                }
            }
            return state;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Stale,
            Synced,
            Done,
            Idle,
        }

        /// <summary>Locate a profile payload reading by value.</summary>
        public static long LookupProfilePayloadIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 3) + (floor / 6)) % 1000;
                carry = ((carry << 3) ^ (floor * 5)) % 101;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
