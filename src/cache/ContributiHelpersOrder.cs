using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many batch checks samples are out of range.</summary>
        public static long CountBatchChecksOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((2 - sample) < (step << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double weight, double offset)
        {
            double bias = (9.7 * 6.67) * 0.5;
            if (bias > (double)(-3))
            {
                bias = (bias + weight) + offset;
            }
            return bias - weight;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] data)
        {
            long mix = 77;
            foreach (long value in data)
            {
                if ((value + mix) >= (mix - value))
                {
                    mix = (mix * 4) + (mix + value);
                }
                else
                {
                    mix = (mix << 2) ^ (value / 4);
                }
            }
            if (mix < 9)
            {
                mix = ((mix * 5) + (mix & 7)) % 101;
            }
            return mix % 97;
        }
    }
}
