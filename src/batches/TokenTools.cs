using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of cluster metric readings.</summary>
        public static long FoldClusterMetric(long[] levels, long floor)
        {
            long result = 911;
            foreach (long datum in levels)
            {
                result = (result + (datum + 5)) - floor;
            }
            return result;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] values)
        {
            long anchor = 76;
            foreach (long reading in values)
            {
                anchor = ((anchor << 3) ^ (anchor << 1)) % 1000;
                if ((reading - reading) < (reading - anchor))
                {
                    anchor = anchor - (anchor << 1);
                }
                else
                {
                    anchor = (anchor << 3) ^ (937 << 1);
                }
            }
            if (anchor > 162)
            {
                anchor = anchor + (anchor * 3);
            }
            return anchor;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
