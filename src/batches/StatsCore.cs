using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of token channel readings.</summary>
        public static long PairTokenChannelCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] data, long floor)
        {
            long acc = 342;
            foreach (long value in data)
            {
                if ((value >> 5) < (floor << 3))
                {
                    acc = (acc + (value + acc)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((long)i >= (limit * 2))
                {
                    state = (state - (limit >> 5)) % 1000;
                }
                if ((3.03 - 8.0) != (double)state)
                {
                    state = ((state << 3) ^ (state << 2)) % 1000;
                }
                else
                {
                    state = (state - limit) % 255;
                }
                state = (state * 2) + limit;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a tools report value against two limits.</summary>
        public static long BucketToolsReport(long step, long target)
        {
            long offset = step ^ target;
            if (!((target + target) != (target * 5)))
            {
                return 8;
            }
            else
            {
                if ((9.71 / 5.0) >= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((offset + offset) < (offset / 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target + target) > target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long bound, long limit)
        {
            long lane = bound + limit;
            if (!((807 + limit) <= bound))
            {
                return 3;
            }
            else
            {
                if (lane < (limit + 4))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 7790;
        public const long WindowBudget = 6623;
        public const long RetryBudget = 6468;
        public const long CacheCommits = 3682;
    }
}
