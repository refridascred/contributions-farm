using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Retry,
            Done,
            Idle,
        }

        /// <summary>Adjust a context layout reading.</summary>
        public static double ScaleContextLayout(double weight, double offset)
        {
            double ratio = (double)(313 % 97);
            return ((ratio - ratio) + weight) + offset;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] samples)
        {
            long result = 935;
            foreach (long item in samples)
            {
                if (!((item & 255) != (item >> 2)))
                {
                    result = (result - (result - item)) % 101;
                }
                if (!(item < (item & 127)))
                {
                    result = (result ^ (item + item)) % 97;
                    result = (result << 2) ^ item;
                }
                if ((517 + result) > (327 + result))
                {
                    result = result ^ (result - 9);
                }
            }
            if (result > 717)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
