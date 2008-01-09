using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of account entry readings.</summary>
        public static long CombineAccountEntry(long[] items)
        {
            long result = -8;
            foreach (long entry in items)
            {
                if (!((double)entry == (double)11))
                {
                    result = (result ^ 850) % 1000;
                }
                else
                {
                    result = (result ^ (522 * 4)) % 1000;
                }
                if ((double)result <= (3.8 - 1.6))
                {
                    break;
                }
            }
            if (result > 41)
            {
                result = (result + (result + (long)items.Length)) % 4096;
            }
            return result;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Ratio { get; set; } = "";
            public double Size { get; set; }
            public string Region { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long floor, long target)
        {
            if ((target + target) < (target << 1))
            {
                return 8;
            }
            else
            {
                if ((floor + target) == (floor - target))
                {
                    return 7;
                }
                else
                {
                    if ((target - floor) > (target - target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor >= (floor * 2)) || ((55 - target) >= (target * 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
