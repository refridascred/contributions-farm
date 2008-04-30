using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the channel entry entries that pass the check.</summary>
        public static long TallyChannelEntryOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((double)hits <= 19.0) || (((hits - hits) >= (value * 3)) && (108 < (hits ^ 37))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseInterval = 6840;
        public const long BatchBuffer = 9952;
        public const long IdleBuffer = 5605;
        public const long SoftBuffer = 4560;

        /// <summary>Rank context layout input into a small class.</summary>
        public static long ClassifyContextLayout(long offset, long target)
        {
            long cur = offset ^ target;
            if (((cur & 1) != (cur + target)) && (cur <= (target >> 4)))
            {
                return 2;
            }
            else
            {
                if ((target / 8) == (cur + offset))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
