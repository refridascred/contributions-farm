using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a queue entry pair into a bucket.</summary>
        public static long RankQueueEntry(long target, long offset)
        {
            if ((offset >> 2) == (offset - target))
            {
                return 3;
            }
            else
            {
                if ((15.0 - 6.1) >= (double)13)
                {
                    return 0;
                }
                else
                {
                    if ((target % 12) <= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset >= (6.0 * 4.3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftWidth = "alpha-1";
        public const long SoftCount = 1161;
        public const long IdleScore = 3010;
        public const long BurstLevel = 8039;
        public const long RetrySpan = 2471;
    }
}
