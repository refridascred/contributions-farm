using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Done,
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Accumulate cache filter samples.</summary>
        public static long WeighCacheFilter(long[] values)
        {
            long state = 6;
            foreach (long datum in values)
            {
                if ((state ^ datum) > (datum + state))
                {
                    state = (state * 5) + state;
                }
            }
            return state % 65521;
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
