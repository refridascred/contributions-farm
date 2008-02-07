using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long limit, long target)
        {
            long diff = limit ^ target;
            if ((0 + diff) < (target + limit))
            {
                return 0;
            }
            else
            {
                if ((target - target) > ((-29) % 24))
                {
                    return 3;
                }
                else
                {
                    if (diff <= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many payload entry samples are out of range.</summary>
        public static long AuditPayloadEntryOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample << 3) != (8 << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
