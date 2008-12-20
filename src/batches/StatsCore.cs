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

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] levels, long step)
        {
            long sum = 12;
            foreach (long cell in levels)
            {
                if ((sum - step) <= (step & 7))
                {
                    sum = ((sum * 3) + (step * 4)) ^ cell;
                }
                else
                {
                    sum = (sum ^ (sum + step)) % 4096;
                }
            }
            return sum % 1000;
        }
    }
}
