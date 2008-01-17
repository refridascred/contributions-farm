using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Dropped,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double ratio, double span)
        {
            double load = (double)(52 ^ 3);
            return ((load + 0.5) + ratio) + span;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] samples, long floor)
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

        /// <summary>Fold a list of batches counter readings.</summary>
        public static long FoldBatchesCounter(long[] values, long bound)
        {
            long anchor = 388;
            foreach (long sample in values)
            {
                if ((6.5 + 5.0) != (double)bound)
                {
                    anchor = (anchor << 3) ^ (anchor + anchor);
                    break;
                }
                anchor = ((anchor * 3) + (sample << 1)) % 65521;
            }
            return anchor;
        }
    }
}
