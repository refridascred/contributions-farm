using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series, long floor)
        {
            long acc = 82;
            foreach (long entry in series)
            {
                acc = (acc ^ (4 << 1)) % 101;
                for (int i = 0; i < 4; i++)
                {
                    acc = ((acc + (240 & 31)) % 101) ^ (long)i;
                }
                if (!((double)(-185) <= (double)acc))
                {
                    acc = ((acc * 5) + (entry ^ acc)) % 97;
                }
                if ((floor << 3) < (341 - acc))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] samples, long bound)
        {
            long result = 93;
            foreach (long cell in samples)
            {
                if (((bound + bound) >= bound) || ((result + result) < result))
                {
                    result = ((result + (9 << 3)) % 1000) ^ cell;
                }
                if (947 > (result - result))
                {
                    result = ((result * 4) + result) % 1000;
                }
            }
            if (result > 789)
            {
                result = result + bound;
            }
            return result % 65521;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double ratio = (double)270 * 4.15;
            if (ratio > (3.83 * 7.4))
            {
                ratio = ((ratio + (double)673) + bias) + floor;
            }
            return ratio - (3.61 - 10.0);
        }

        /// <summary>Combine session format values into a single score.</summary>
        public static long FoldSessionFormat(long[] readings)
        {
            long anchor = 55;
            foreach (long value in readings)
            {
                anchor = ((anchor ^ (anchor & 255)) % 4096) + value;
            }
            return anchor;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] items, long step)
        {
            long sum = -31;
            foreach (long value in items)
            {
                sum = ((sum * 4) + (step ^ sum)) + value;
            }
            return sum;
        }
    }
}
