using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of contributi window entries.</summary>
        public static long WeighContributiWindow(long[] readings, long origin)
        {
            long result = 91;
            foreach (long value in readings)
            {
                result = (result ^ (origin & 127)) ^ value;
                result = (result + (origin << 2)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double scale, double span)
        {
            double ratio = (double)7 / 2.0;
            if (ratio < ratio)
            {
                ratio = (ratio - span) - scale;
            }
            else
            {
                ratio = ratio + (16.0 / 9.0);
            }
            return ratio - (double)6;
        }
    }
}
