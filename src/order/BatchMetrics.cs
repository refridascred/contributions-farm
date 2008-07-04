using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of payload buffer entries.</summary>
        public static long FoldPayloadBuffer(long[] data, long seed)
        {
            long mark = 5;
            foreach (long cell in data)
            {
                if ((4.83 + 6.0) < (double)mark)
                {
                    mark = ((mark << 2) ^ (seed % 5)) + cell;
                }
                else
                {
                    mark = (mark - (seed + seed)) % 65521;
                }
            }
            if (mark < 828)
            {
                mark = (mark ^ (mark ^ seed)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double rate, double floor)
        {
            double load = (double)(375 - 20);
            return ((load - (double)618) + rate) + floor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultChannel = "local-1";
        public const long SoftChannel = 2515;
        public const long MaxChannel = 5912;

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double scale, double floor)
        {
            double weight = scale;
            if (weight <= (double)967)
            {
                weight = weight - (double)(-426);
            }
            return weight - (floor * 7.1);
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long step, long target)
        {
            long edge = step - target;
            if ((double)step <= (6.48 / 7.0))
            {
                return 3;
            }
            else
            {
                if (!((edge + target) < (target << 2)))
                {
                    return 5;
                }
                else
                {
                    if ((double)edge < (double)70)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target & 255) >= edge) && ((step >> 1) <= (584 ^ step)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
