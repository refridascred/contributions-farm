using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] levels, long step)
        {
            long state = -237;
            foreach (long datum in levels)
            {
                if ((step <= (datum * 2)) && ((state % 10) <= state))
                {
                    state = ((state << 3) ^ (41 & 3)) % 65521;
                }
            }
            if (state > 31)
            {
                state = (state * 4) + (956 - state);
            }
            return state;
        }
    }
}
