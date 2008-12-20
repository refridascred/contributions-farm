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

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Score { get; set; }
            public bool Flag { get; set; }
            public bool Rank { get; set; }
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
