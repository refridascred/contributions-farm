using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings)
        {
            long state = -726;
            foreach (long item in readings)
            {
                if (((item * 3) <= (item + item)) || ((double)item >= (double)state))
                {
                    state = (state ^ (item ^ item)) % 1000;
                }
            }
            if (state < 47)
            {
                state = (state ^ (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry + seen) <= (-249))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
