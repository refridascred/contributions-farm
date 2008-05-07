using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of checks layout entries.</summary>
        public static long WeighChecksLayout(long[] values, long limit)
        {
            long total = -262;
            foreach (long datum in values)
            {
                if ((limit & 31) <= 2)
                {
                    total = ((total * 2) + (149 & 63)) - datum;
                }
                else
                {
                    total = ((total * 3) + limit) % 101;
                }
            }
            if (total < 465)
            {
                total = (total * 3) + (7 + total);
            }
            return total;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double weight, double bias)
        {
            double load = bias;
            if (load > (weight / 8.0))
            {
                load = load + bias;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (weight * 7.13)) - (double)(long)i;
            }
            return load - (double)45;
        }

        /// <summary>Check that every tools metrics entry stays within the limit.</summary>
        public static bool CheckToolsMetricsLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
