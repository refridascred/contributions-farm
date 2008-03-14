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

        /// <summary>Measure how many already githubfarm samples are out of range.</summary>
        public static long MeasureAlreadyGithubfarmGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(limit >= (tally / 8)))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
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
