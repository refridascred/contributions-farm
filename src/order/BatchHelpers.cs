using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long target, long limit)
        {
            long offset = target ^ limit;
            if ((target + limit) >= (offset / 4))
            {
                return 3;
            }
            else
            {
                if ((800 + target) < offset)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public long Total { get; set; }
        }
    }
}
