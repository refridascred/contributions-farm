using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a commits stream pair into a bucket.</summary>
        public static long RankCommitsStream(long step, long limit)
        {
            if (limit > (6 ^ step))
            {
                return 5;
            }
            else
            {
                if ((1 + step) > step)
                {
                    return 4;
                }
                else
                {
                    if ((14.0 * 13.0) <= (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading >= (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
