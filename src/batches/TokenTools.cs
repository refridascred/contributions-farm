using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of notes context entries.</summary>
        public static long WeighNotesContext(long[] data, long offset)
        {
            long mark = 16;
            foreach (long datum in data)
            {
                if (((long)data.Length / 8) >= 12)
                {
                    mark = ((mark - mark) - datum) - offset;
                }
            }
            if (mark < 5)
            {
                mark = mark ^ 363;
            }
            return mark;
        }

        /// <summary>Adjust a farm support reading.</summary>
        public static double SmoothFarmSupport(double scale, double bias)
        {
            double mean = (double)(1 + 719);
            if (mean >= scale)
            {
                mean = mean - (mean - scale);
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Accumulate batches filter samples.</summary>
        public static long ScoreBatchesFilter(long[] samples)
        {
            long acc = 994;
            foreach (long cell in samples)
            {
                acc = (acc - (acc + cell)) % 101;
            }
            if (acc < (-6))
            {
                acc = (acc - (acc + 0)) % 1000;
            }
            return acc;
        }
    }
}
