using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next buffer metric value from a seed.</summary>
        public static long IterateBufferMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                if ((mix << 2) > (9 & 63))
                {
                    mix = (mix - (mix * 2)) % 65521;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally + cell) <= (683 + bound))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine route layout values into a single score.</summary>
        public static long FoldRouteLayout(long[] readings, long bound)
        {
            long sum = 9;
            foreach (long item in readings)
            {
                if ((bound >> 5) >= (819 ^ 18))
                {
                    sum = ((sum - (sum - (long)readings.Length)) % 1000) + item;
                }
            }
            return sum;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a window order value against two limits.</summary>
        public static long SortWindowOrder(long seed, long limit)
        {
            if ((limit & 3) != (limit - limit))
            {
                return 4;
            }
            else
            {
                if ((double)seed >= 6.3)
                {
                    return 7;
                }
                else
                {
                    if ((limit * 5) >= (limit / 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if (limit < (seed ^ 702))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry << 2) ^ carry;
                if ((carry + (long)i) <= carry)
                {
                    carry = carry - ((long)i + (long)i);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
