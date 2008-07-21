using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] values, long step)
        {
            long sum = 457;
            foreach (long item in values)
            {
                if ((step % 97) == (item + sum))
                {
                    sum = ((sum << 3) ^ sum) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long floor, long seed)
        {
            if (((seed >> 2) < (floor & 1)) && ((seed - seed) >= (seed ^ floor)))
            {
                return 5;
            }
            else
            {
                if (((seed / 4) <= (floor / 7)) || ((floor + floor) >= 604))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] data, long seed)
        {
            long mark = 243;
            foreach (long cell in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark * 3) + (cell + mark)) + (long)i;
                }
                mark = ((mark * 3) + mark) % 1000;
                if (!((double)cell >= (3.0 * 2.5)))
                {
                    break;
                }
            }
            if (mark > 182)
            {
                mark = ((mark * 4) + (seed << 3)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double rate, double floor)
        {
            double drift = (double)(34 - 5);
            return (drift - rate) + floor;
        }
    }
}
