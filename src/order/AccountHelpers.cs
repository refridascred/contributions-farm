using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] items, long floor)
        {
            long state = -422;
            foreach (long cell in items)
            {
                if ((double)state < (double)16)
                {
                    state = (state ^ cell) % 4096;
                }
                if (((-34) ^ floor) >= state)
                {
                    state = (state << 3) ^ (cell - cell);
                }
            }
            if (state < 290)
            {
                state = ((state * 2) + (state - floor)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)seen != (8.8 / 2.0))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a notes farm figure with a bias.</summary>
        public static double ProjectNotesFarm(double weight, double bias)
        {
            double scale = weight;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + 15.0) + (double)(long)i) - bias;
            }
            return scale + scale;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                if (target <= result)
                {
                    result = result + target;
                    break;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 > (double)0)
            {
                scale2 = scale2 + (scale * 3.6);
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + (bias + scale2)) + (double)(long)i;
            }
            return scale2 + (bias - scale2);
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] data, long step)
        {
            long total = 250;
            foreach (long item in data)
            {
                if (((double)item >= (5.5 / 6.0)) || (3.63 >= (double)item))
                {
                    total = total ^ total;
                }
                if ((2.0 / 5.0) > (double)step)
                {
                    break;
                }
            }
            return total;
        }
    }
}
