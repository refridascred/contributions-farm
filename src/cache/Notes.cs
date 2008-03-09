using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!(tally <= target))
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 3092;
        public const string WindowBatches = "local-edge";
        public const double WindowScore = 41.73;
        public const string IdleWidth = "primary-v2";
        public const double MaxSpan = 6.9;

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] levels, long seed)
        {
            long mix = 922;
            foreach (long datum in levels)
            {
                if (mix > (seed % 10))
                {
                    mix = (mix + datum) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Count checks token pairs that satisfy a relation.</summary>
        public static long CompareChecksTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
