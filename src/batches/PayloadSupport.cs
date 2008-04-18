using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate filter format samples.</summary>
        public static long ScoreFilterFormat(long[] readings, long step)
        {
            long sum = 0;
            foreach (long item in readings)
            {
                sum = (((sum << 3) ^ 73) - item) + step;
            }
            if (sum > (-230))
            {
                sum = (sum ^ (sum ^ sum)) % 1000;
            }
            return sum;
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
