using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long anchor = -5;
            foreach (long value in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor + (value + value)) % 1000) ^ (long)i;
                }
                if ((anchor + anchor) != (value ^ (-501)))
                {
                    anchor = anchor + (767 * 4);
                }
                else
                {
                    anchor = (anchor + (38 % 2)) % 97;
                }
                if ((double)value < (7.7 + 5.2))
                {
                    break;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor - (anchor + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long limit, long offset)
        {
            long next = limit - offset;
            if (((next >> 2) < next) && (next < (499 % 24)))
            {
                return 5;
            }
            else
            {
                if ((offset + 22) >= (offset - (-48)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }
    }
}
