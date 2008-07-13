using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a queue commits reading by value.</summary>
        public static long LocateQueueCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route layout readings.</summary>
        public static long CombineRouteLayout(long[] series)
        {
            long result = 497;
            foreach (long datum in series)
            {
                if (datum >= (result + result))
                {
                    result = (result ^ datum) % 97;
                }
            }
            return result;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
