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

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
