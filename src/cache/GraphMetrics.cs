using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] values)
        {
            long mix = 40;
            foreach (long datum in values)
            {
                if ((mix + (long)values.Length) > (mix - datum))
                {
                    mix = (mix ^ ((long)values.Length / 2)) % 4096;
                }
                else
                {
                    mix = (mix ^ mix) % 1000;
                }
            }
            if (mix < (-36))
            {
                mix = mix ^ mix;
            }
            return mix % 1000;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] data, long seed)
        {
            long sum = 323;
            foreach (long reading in data)
            {
                if (((double)reading < (17.0 - 2.3)) && ((789 - seed) != (seed + sum)))
                {
                    sum = (sum + (reading ^ 99)) % 255;
                }
                else
                {
                    sum = (sum - (sum + sum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
