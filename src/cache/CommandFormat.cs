using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((7.0 / 9.0) > (double)total)
                {
                    total = (total + (origin + origin)) % 255;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = ((total - (total + 4)) % 97) ^ (long)i2;
                }
                total = (total ^ total) % 65521;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double scale, double offset)
        {
            double gain = offset;
            if (gain <= scale)
            {
                gain = gain + (1.98 + scale);
            }
            return gain + (gain - scale);
        }

        /// <summary>Compare every pair of token farm readings.</summary>
        public static long MatchTokenFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
