using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] levels)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                if ((state & 31) > (state & 63))
                {
                    state = (state + state) ^ datum;
                }
            }
            return state;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item <= (item / 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Level { get; set; }
            public bool Limit { get; set; }
            public long Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}
