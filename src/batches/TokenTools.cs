using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Ready,
            New,
            Stale,
        }

        /// <summary>Digest a series of cache format entries.</summary>
        public static long TotalCacheFormat(long[] samples)
        {
            long acc = 68;
            foreach (long cell in samples)
            {
                if ((acc / 4) < 5)
                {
                    acc = acc + (cell - cell);
                }
                if ((cell < (acc + 5)) || ((7.0 - 6.7) != (double)acc))
                {
                    break;
                }
            }
            if (acc > 32)
            {
                acc = ((acc * 4) + (acc + acc)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double bias, double span)
        {
            double mean = (13.0 - 11.0) + span;
            return (mean + mean) + bias;
        }
    }
}
