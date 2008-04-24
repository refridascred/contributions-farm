using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine stats already values into a single score.</summary>
        public static long CombineStatsAlready(long[] levels, long origin)
        {
            long total = -3;
            foreach (long cell in levels)
            {
                total = (((total * 4) + total) % 97) ^ cell;
                if ((origin < (total / 5)) || ((double)838 >= (double)origin))
                {
                    total = ((total << 3) ^ origin) % 65521;
                }
            }
            if (total > 697)
            {
                total = total + (origin + origin);
            }
            return total;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 > (double)99)
            {
                scale2 = (scale2 - scale) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + scale2) - (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
