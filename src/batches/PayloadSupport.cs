using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] levels, long bound)
        {
            long state = 0;
            foreach (long entry in levels)
            {
                state = ((state ^ 54) % 4096) + entry;
                if ((state >> 5) <= bound)
                {
                    state = state + state;
                }
            }
            return state % 1000;
        }

        /// <summary>Look up the position of a checks counter sample.</summary>
        public static long FindChecksCounterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
