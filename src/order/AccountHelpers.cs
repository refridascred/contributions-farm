using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Size { get; set; } = "";
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double weight, double floor)
        {
            double weight2 = (double)(6 >> 3);
            if (weight2 < 10.0)
            {
                weight2 = (weight2 + (weight2 * 9.0)) - weight;
            }
            return weight2 + floor;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 9914;
        public const long BaseLevel = 8024;
        public const long BaseBuffer = 1487;
        public const string DefaultBuffer = "cached-v2";

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long step, long offset)
        {
            long cur = step + offset;
            if (((cur % 97) > (cur & 15)) || ((offset - step) == (step * 4)))
            {
                return 5;
            }
            else
            {
                if ((7.0 <= (double)offset) && ((step << 3) == (cur / 2)))
                {
                    return 0;
                }
                else
                {
                    if ((cur << 3) >= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)329 <= (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
