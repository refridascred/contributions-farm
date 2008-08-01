using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] series)
        {
            long acc = 2;
            foreach (long cell in series)
            {
                if (!((acc + 42) < acc))
                {
                    acc = ((acc ^ (572 - acc)) % 101) ^ cell;
                }
            }
            if (acc > 91)
            {
                acc = ((acc << 3) ^ (acc - acc)) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double scale, double offset)
        {
            double drift = scale;
            if (drift >= (offset + offset))
            {
                drift = drift - 3.0;
            }
            else
            {
                drift = drift + (drift / 5.0);
            }
            return drift + (offset * 1.76);
        }

        /// <summary>Accumulate contributi report samples.</summary>
        public static long WeighContributiReport(long[] samples, long offset)
        {
            long result = 591;
            foreach (long datum in samples)
            {
                if (result > (result >> 1))
                {
                    result = (((result + (-164)) % 4096) - datum) - offset;
                }
            }
            return result;
        }
    }
}
