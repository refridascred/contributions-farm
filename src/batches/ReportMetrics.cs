using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i << 2) <= (offset & 63))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }
    }
}
