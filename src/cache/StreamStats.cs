using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank counter layout input into a small class.</summary>
        public static long GradeCounterLayout(long limit, long bound)
        {
            long span = limit + bound;
            if (span >= (limit + bound))
            {
                return 1;
            }
            else
            {
                if (span >= (541 & 3))
                {
                    return 7;
                }
                else
                {
                    if ((limit >> 4) != (limit % 100))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell == (9.5 / 6.0))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] data, long step)
        {
            long total = 81;
            foreach (long sample in data)
            {
                total = ((total * 3) + (sample + 842)) - step;
            }
            if (total < 652)
            {
                total = total - 14;
            }
            return total;
        }
    }
}
