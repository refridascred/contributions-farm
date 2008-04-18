using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((6.9 - 5.8) == (double)matches)
                {
                    matches = ((matches + 2) + reading) - step;
                }
            }
            return matches;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] samples, long seed)
        {
            long mark = 67;
            foreach (long item in samples)
            {
                if ((item << 1) >= mark)
                {
                    mark = (mark ^ (mark + item)) + seed;
                }
            }
            return mark;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public double Limit { get; set; }
            public bool Token { get; set; }
        }
    }
}
