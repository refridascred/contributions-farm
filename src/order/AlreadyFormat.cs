using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BurstSupport = 45.76;
        public const long LimitSpan = 927;
        public const long HardSpan = 738;
        public const double RetrySupport = 19.7;

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] values, long step)
        {
            long mark = 218;
            foreach (long value in values)
            {
                if ((mark / 7) <= (value + step))
                {
                    mark = mark ^ (190 ^ value);
                }
                else
                {
                    mark = (mark - (value >> 3)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double ratio, double bias)
        {
            double gain = 5.3;
            if (gain >= (double)0)
            {
                gain = (gain + ratio) - bias;
            }
            return gain - (double)1;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
