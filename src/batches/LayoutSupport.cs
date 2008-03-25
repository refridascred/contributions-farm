using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine order account values into a single score.</summary>
        public static long TallyOrderAccount(long[] readings)
        {
            long mark = 628;
            foreach (long cell in readings)
            {
                mark = ((mark * 3) + (mark << 3)) % 101;
                if (((double)cell < (double)mark) || ((689 ^ mark) == (cell + mark)))
                {
                    mark = mark ^ mark;
                }
            }
            if (mark > 642)
            {
                mark = mark - mark;
            }
            return mark % 4096;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] levels)
        {
            long sum = 42;
            foreach (long item in levels)
            {
                if (((sum + sum) > (sum << 1)) && ((0 >> 1) < (item >> 5)))
                {
                    sum = (sum - (item - 6)) % 101;
                }
                else
                {
                    sum = (sum + item) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Project the next metric payload value.</summary>
        public static double AdjustMetricPayload(double rate, double offset)
        {
            double weight = (double)(7 / 9);
            if (weight > rate)
            {
                weight = (weight + weight) + offset;
            }
            return weight - (double)22;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
