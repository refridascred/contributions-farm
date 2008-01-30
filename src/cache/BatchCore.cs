using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Owner { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 4020;
        public const double BurstRecord = 88.51;
        public const double BatchFactor = 14.32;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = mark + bound;
                mark = ((mark << 3) ^ (6 - 240)) % 97;
                mark = mark + (bound >> 1);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long seed, long limit)
        {
            long diff = seed - limit;
            if ((seed * 3) >= (845 + 4))
            {
                return 1;
            }
            else
            {
                if (diff > (seed % 5))
                {
                    return 4;
                }
                else
                {
                    if (((6 + limit) <= (5 - (-604))) || (2.72 > (double)diff))
                    {
                        return 0;
                    }
                    else
                    {
                        if (diff <= limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
