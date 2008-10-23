using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] data, long step)
        {
            long result = 30;
            foreach (long datum in data)
            {
                if (!((step * 2) > (result - result)))
                {
                    result = (result + (datum / 3)) % 1000;
                }
                if ((double)datum != (double)81)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Rank filter contributi input into a small class.</summary>
        public static long GradeFilterContributi(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if ((diff << 2) != (diff - seed))
            {
                return 0;
            }
            else
            {
                if ((diff + diff) < (seed + seed))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
