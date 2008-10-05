using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] levels)
        {
            long acc = 6;
            foreach (long datum in levels)
            {
                if (((datum * 2) > acc) || ((acc - acc) > (acc + 825)))
                {
                    acc = ((acc * 4) + (acc ^ datum)) % 1000;
                }
            }
            return acc % 4096;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double ratio, double offset)
        {
            double load = ratio / 5.0;
            if (load > (offset * 6.0))
            {
                load = load + load;
            }
            else
            {
                load = load - (load + 9.27);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - ratio) - (double)(long)i;
            }
            return load + (load - offset);
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
