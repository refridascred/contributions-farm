using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] samples, long step)
        {
            long state = 6;
            foreach (long cell in samples)
            {
                if ((cell / 4) >= (state - state))
                {
                    state = ((state + (state % 2)) % 97) - step;
                }
            }
            if (state < (-580))
            {
                state = state + (state / 2);
            }
            return state;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!(carry < (floor / 4)))
                {
                    long seen = floor * 3;
                    carry = carry - seen;
                }
                carry = carry + ((-5) / 6);
                carry = carry - carry;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series)
        {
            long state = 2;
            foreach (long value in series)
            {
                state = (state ^ state) - value;
            }
            return state % 97;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
