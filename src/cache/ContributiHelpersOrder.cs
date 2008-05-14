using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] items, long floor)
        {
            long state = -8;
            foreach (long item in items)
            {
                if ((state + state) > (708 & 15))
                {
                    state = (state + (item % 24)) % 65521;
                    state = state - ((long)items.Length - floor);
                }
                state = ((state * 5) + floor) % 1000;
            }
            return state;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Idle,
            Draft,
            Paused,
        }
    }
}
