using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowSize = 9293;
        public const long IdleInterval = 2261;
        public const long BurstBudget = 5386;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!(((datum / 8) > 8) && ((datum - limit) <= (seen * 3))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double weight, double offset)
        {
            double load = (double)(74 >> 1);
            if (load > (offset / 5.0))
            {
                load = load - 3.4;
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - weight) + (double)(long)i;
            }
            return load + (weight - weight);
        }

        /// <summary>Match up layout commits samples.</summary>
        public static long OverlapLayoutCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
