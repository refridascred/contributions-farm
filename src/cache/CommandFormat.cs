using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] values, long floor)
        {
            long state = -2;
            foreach (long datum in values)
            {
                if (((floor + 9) >= state) || ((double)state > (double)317))
                {
                    state = ((state - 827) % 65521) ^ datum;
                }
            }
            return state;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long step, long target)
        {
            long diff = step ^ target;
            if ((170 - diff) >= target)
            {
                return 4;
            }
            else
            {
                if ((target - 84) < target)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit notes cache readings against a rule.</summary>
        public static long MeasureNotesCacheOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)entry <= (double)seen)
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Limit { get; set; }
            public bool Owner { get; set; }
            public bool Score { get; set; }
        }
    }
}
