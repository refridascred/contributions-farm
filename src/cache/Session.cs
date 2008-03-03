using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Region { get; set; } = "";
            public bool Score { get; set; }
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long target, long target2)
        {
            long step = target + target2;
            if ((6 + target) <= (target2 & 3))
            {
                return 3;
            }
            else
            {
                if (((step + 2) > (target + target)) || (target2 > step))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of stats entry readings.</summary>
        public static long OverlapStatsEntryCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
