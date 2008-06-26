using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two editor format measurements.</summary>
        public static double ProjectEditorFormat(double rate, double span)
        {
            double drift = (double)6 - rate;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - 19.0) - (double)(long)i) - span;
            }
            return drift - (drift * 9.22);
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Rank payload queue input into a small class.</summary>
        public static long SortPayloadQueue(long step, long target)
        {
            long gap = step ^ target;
            if (!((69 >> 4) < gap))
            {
                return 2;
            }
            else
            {
                if ((target ^ 764) >= gap)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
