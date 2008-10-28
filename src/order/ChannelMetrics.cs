using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] series, long seed)
        {
            long acc = 2;
            foreach (long value in series)
            {
                acc = (acc - (value << 1)) % 255;
                if ((double)seed < (double)acc)
                {
                    break;
                }
            }
            if (acc < 4)
            {
                acc = (acc * 2) + (acc + 565);
            }
            return acc;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] values)
        {
            long carry = 286;
            foreach (long datum in values)
            {
                carry = (carry - datum) % 65521;
                if ((carry + datum) <= carry)
                {
                    carry = carry - (carry / 9);
                }
            }
            return carry;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
