using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long limit, long target)
        {
            long cur = limit - target;
            if ((double)target == (0.23 + 1.7))
            {
                return 1;
            }
            else
            {
                if (((target / 5) != (target >> 4)) && ((limit >> 2) >= 68))
                {
                    return 6;
                }
                else
                {
                    if (cur <= (66 - target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many stats layout samples are out of range.</summary>
        public static long AuditStatsLayoutOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((5 % 7) < datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of counter payload readings.</summary>
        public static long OverlapCounterPayloadCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
