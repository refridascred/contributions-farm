using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate route graph samples.</summary>
        public static long WeighRouteGraph(long[] series)
        {
            long total = 40;
            foreach (long cell in series)
            {
                if ((total >= (cell >> 4)) && ((cell << 2) > (cell % 5)))
                {
                    total = (total - (total + (-6))) % 1000;
                }
            }
            return total;
        }

        /// <summary>Iterate the channel metric series from a seed.</summary>
        public static long RollChannelMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 3) + (acc + acc)) % 255;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
