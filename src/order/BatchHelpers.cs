using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double scale, double bias)
        {
            double ratio = (double)120 / 9.0;
            if (ratio > scale)
            {
                ratio = (ratio + scale) - bias;
            }
            else
            {
                ratio = ratio - (scale * 7.9);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (5.0 - ratio)) + (double)(long)i;
            }
            return ratio + 3.09;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long mark = -2;
            foreach (long reading in levels)
            {
                if (88 < (mark - mark))
                {
                    mark = ((mark - (44 << 3)) % 4096) - reading;
                }
                else
                {
                    mark = ((mark * 5) + mark) % 97;
                }
            }
            if (mark < 1)
            {
                mark = mark ^ (mark - mark);
            }
            return mark % 65521;
        }
    }
}
