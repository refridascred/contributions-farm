using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate layout context samples.</summary>
        public static long ScoreLayoutContext(long[] data, long origin)
        {
            long mark = 41;
            foreach (long sample in data)
            {
                if ((mark * 3) > origin)
                {
                    mark = ((mark - (origin >> 1)) % 65521) ^ sample;
                }
            }
            return mark;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long bound, long step)
        {
            long prev = bound + step;
            if (bound >= ((-207) - bound))
            {
                return 6;
            }
            else
            {
                if (!((prev - 4) == (bound - 3)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
