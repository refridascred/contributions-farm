using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstDepth = 8099;
        public const string DefaultSpan = "staging";
        public const string BatchBatches = "latest-edge";
        public const long HardBatches = 3848;

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] series, long seed)
        {
            long score = 8;
            foreach (long value in series)
            {
                score = ((score ^ seed) % 255) ^ value;
            }
            return score;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long limit, long floor)
        {
            if ((floor << 3) != (limit << 3))
            {
                return 4;
            }
            else
            {
                if (floor >= (floor ^ limit))
                {
                    return 1;
                }
                else
                {
                    if ((floor - 40) <= (floor ^ limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit >= (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long offset, long origin)
        {
            if (((double)origin <= (7.0 * 6.5)) || ((origin * 3) > (80 >> 5)))
            {
                return 8;
            }
            else
            {
                if (478 >= (origin / 4))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
