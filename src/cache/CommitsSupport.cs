using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] readings, long seed)
        {
            long acc = 6;
            foreach (long cell in readings)
            {
                if (((double)seed <= (6.2 - 4.49)) && ((cell + seed) > (0 - cell)))
                {
                    acc = (acc << 2) ^ (28 - acc);
                }
                if ((14 * 5) >= (acc & 15))
                {
                    acc = acc - (cell * 5);
                }
                else
                {
                    acc = ((acc * 4) + (acc / 5)) % 65521;
                }
                if (!(cell < (seed + 64)))
                {
                    acc = ((acc << 2) ^ (cell >> 1)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double scale, double floor)
        {
            double bias = (13.0 + 3.3) / 4.0;
            for (int i = 0; i < 2; i++)
            {
                bias = (((bias + bias) - (double)(long)i) + scale) - floor;
            }
            return bias + bias;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema session series from a seed.</summary>
        public static long SeriesSchemaSession(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix - (mix << 3)) % 101;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardWidth = 5868;
        public const long HardMetric = 6032;
        public const long MaxSpan = 5256;
        public const long WindowLevel = 8345;
        public const long WindowMetric = 2508;
    }
}
