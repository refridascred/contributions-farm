using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two context record measurements.</summary>
        public static double ScaleContextRecord(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 < weight2)
            {
                weight2 = (weight2 + (weight * 9.6)) - offset;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - 1.73) + (double)(long)i;
            }
            return weight2 + (8.3 * 1.0);
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Flag { get; set; }
            public double Level { get; set; }
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] values)
        {
            long mark = 29;
            foreach (long reading in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = (((mark ^ (mark >> 4)) % 97) - (long)i) ^ reading;
                }
                mark = (mark + (mark & 127)) % 4096;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 7474;
        public const long SoftWidth = 7438;
        public const long CacheTools = 2652;
        public const double IdleScore = 74.15;
        public const double IdleFactor = 74.13;
    }
}
