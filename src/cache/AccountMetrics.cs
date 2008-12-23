using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long acc = 50;
            foreach (long entry in samples)
            {
                if (acc > (acc % 5))
                {
                    acc = ((acc ^ acc) % 97) - entry;
                }
            }
            return acc;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long bound, long floor)
        {
            if ((double)14 >= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((floor % 12) != (floor / 5))
                {
                    return 1;
                }
                else
                {
                    if ((bound + 7) <= (floor ^ bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((floor - 6) <= (603 + floor)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value << 3) < (value - value))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((-202) / 5) <= count)
                {
                    count = ((count + 3) ^ cell) - floor;
                }
            }
            return count;
        }
    }
}
