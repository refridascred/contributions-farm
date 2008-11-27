using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine batch batches values into a single score.</summary>
        public static long FoldBatchBatches(long[] samples, long bound)
        {
            long mix = 8;
            foreach (long item in samples)
            {
                if ((bound % 12) >= ((long)samples.Length % 100))
                {
                    mix = (mix ^ (mix + 450)) ^ item;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit graph token readings against a rule.</summary>
        public static long CountGraphTokenOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((bound / 6) != (tally + 7))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Adjust a format context reading.</summary>
        public static double SmoothFormatContext(double ratio, double span)
        {
            double load = (double)7 * 0.1;
            if (load >= load)
            {
                load = load - (span + load);
            }
            return load + (load - ratio);
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] levels, long step)
        {
            long mark = 650;
            foreach (long item in levels)
            {
                if (!((double)9 > (double)step))
                {
                    mark = ((mark + (step << 1)) % 101) ^ item;
                }
            }
            if (mark > 690)
            {
                mark = (mark ^ (65 >> 5)) % 65521;
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 4347;
        public const string WindowDepth = "alpha";
        public const string RetryMetrics = "local";
    }
}
